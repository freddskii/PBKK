using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sistem_data_mahasiswa;

public partial class Form1 : Form
{
    // Master data source
    private BindingList<Mahasiswa> daftarMahasiswa = new BindingList<Mahasiswa>();

    public Form1()
    {
        InitializeComponent();
        SetupEvents();
    }

    private void SetupEvents()
    {
        Load += Form1_Load;
        btnTambah.Click += btnTambah_Click;
        btnUpdate.Click += btnUpdate_Click;
        btnHapus.Click += btnHapus_Click;
        btnClear.Click += btnClear_Click;
        btnCari.Click += btnCari_Click;
        btnRefresh.Click += btnRefresh_Click;
        dgvMahasiswa.CellClick += dgvMahasiswa_CellClick;
        txtCari.KeyDown += txtCari_KeyDown;

        // KeyPress restrictions to prevent invalid character input directly while typing
        txtNIM.KeyPress += txtNIM_KeyPress;
        txtNama.KeyPress += txtNama_KeyPress;
        txtIPK.KeyPress += txtIPK_KeyPress;

        // Clear errorProvider warning once user modifies the input
        txtNIM.TextChanged += (s, e) => errorProvider.SetError(txtNIM, string.Empty);
        txtNama.TextChanged += (s, e) => errorProvider.SetError(txtNama, string.Empty);
        cmbProdi.SelectedIndexChanged += (s, e) => errorProvider.SetError(cmbProdi, string.Empty);
        cmbProdi.TextChanged += (s, e) => errorProvider.SetError(cmbProdi, string.Empty);
        txtIPK.TextChanged += (s, e) => errorProvider.SetError(txtIPK, string.Empty);
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        // Sample data for demonstration
        daftarMahasiswa.Add(new Mahasiswa("5025211001", "Ahmad Fauzan", "Teknik Informatika", 3.85));
        daftarMahasiswa.Add(new Mahasiswa("5025211024", "Siti Nurhaliza", "Sistem Informasi", 3.92));
        daftarMahasiswa.Add(new Mahasiswa("5025211050", "Budi Pratama", "Sains Data", 3.65));

        dgvMahasiswa.DataSource = daftarMahasiswa;
        ConfigureGridColumns();
        UpdateStatus();
        SetEditMode(false);
    }

    #region Input Restrictions (KeyPress Handlers)

    // Rule 1: NRP must only allow digits (0-9) and control keys (Backspace, Delete, Ctrl+C/V)
    private void txtNIM_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Reject character
            errorProvider.SetError(txtNIM, "NRP hanya boleh berisi angka (0-9).");
        }
    }

    // Rule 2: Nama must only allow letters, spaces, dots, apostrophes, and control keys
    private void txtNama_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar)) return;

        // Allow letters, space, '.', and '\''
        if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '.' && e.KeyChar != '\'')
        {
            e.Handled = true; // Reject character
            errorProvider.SetError(txtNama, "Nama tidak boleh mengandung angka atau simbol.");
        }
    }

    // Rule 3: IPK must only allow digits and at most one decimal separator (',' or '.')
    private void txtIPK_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar)) return;

        if (char.IsDigit(e.KeyChar)) return;

        // Allow one dot or comma
        if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtIPK.Text.Contains('.') && !txtIPK.Text.Contains(','))
            return;

        e.Handled = true; // Reject any other character
        errorProvider.SetError(txtIPK, "IPK hanya boleh berisi angka dan satu tanda desimal (contoh: 3.75).");
    }

    #endregion

    #region Comprehensive Validation

    private bool ValidateInputForm(bool isNewStudent, out string nim, out string nama, out string prodi, out double ipk)
    {
        string inputNim = txtNIM.Text.Trim();
        string inputNama = txtNama.Text.Trim();
        string inputProdi = cmbProdi.Text.Trim();

        nim = inputNim;
        nama = inputNama;
        prodi = inputProdi;
        ipk = 0;

        errorProvider.Clear();
        bool isValid = true;
        Control? firstInvalidControl = null;

        // 1. Validate NRP (Must be exactly 10 digits)
        var nrpValidation = MahasiswaValidator.ValidateNRP(inputNim);
        if (!nrpValidation.IsValid)
        {
            errorProvider.SetError(txtNIM, nrpValidation.ErrorMessage);
            isValid = false;
            firstInvalidControl ??= txtNIM;
        }
        else if (isNewStudent && daftarMahasiswa.Any(m => m.NIM.Equals(inputNim, StringComparison.OrdinalIgnoreCase)))
        {
            // Duplicate NRP check
            string dupMsg = $"NRP '{inputNim}' sudah terdaftar dalam sistem!";
            errorProvider.SetError(txtNIM, dupMsg);
            isValid = false;
            firstInvalidControl ??= txtNIM;
        }

        // 2. Validate Nama (Letters, spaces, dots, apostrophes only, min 3 chars)
        var namaValidation = MahasiswaValidator.ValidateNama(inputNama);
        if (!namaValidation.IsValid)
        {
            errorProvider.SetError(txtNama, namaValidation.ErrorMessage);
            isValid = false;
            firstInvalidControl ??= txtNama;
        }

        // 3. Validate Program Studi
        var prodiValidation = MahasiswaValidator.ValidateProdi(inputProdi);
        if (!prodiValidation.IsValid)
        {
            errorProvider.SetError(cmbProdi, prodiValidation.ErrorMessage);
            isValid = false;
            firstInvalidControl ??= cmbProdi;
        }

        // 4. Validate IPK (0.00 - 4.00)
        var ipkValidation = MahasiswaValidator.ValidateIPK(txtIPK.Text);
        if (!ipkValidation.IsValid)
        {
            errorProvider.SetError(txtIPK, ipkValidation.ErrorMessage);
            isValid = false;
            firstInvalidControl ??= txtIPK;
        }
        else
        {
            ipk = ipkValidation.Value;
        }

        if (!isValid)
        {
            firstInvalidControl?.Focus();
            MessageBox.Show(
                "Terdapat input yang tidak valid! Silakan periksa tanda peringatan merah pada form input.",
                "Validasi Gagal",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        return isValid;
    }

    #endregion

    private void ConfigureGridColumns()
    {
        if (dgvMahasiswa.Columns["NIM"] is DataGridViewColumn colNim)
        {
            colNim.HeaderText = "NRP";
            colNim.FillWeight = 25;
        }

        if (dgvMahasiswa.Columns["Nama"] is DataGridViewColumn colNama)
        {
            colNama.HeaderText = "Nama Mahasiswa";
            colNama.FillWeight = 35;
        }

        if (dgvMahasiswa.Columns["Prodi"] is DataGridViewColumn colProdi)
        {
            colProdi.HeaderText = "Program Studi";
            colProdi.FillWeight = 25;
        }

        if (dgvMahasiswa.Columns["IPK"] is DataGridViewColumn colIpk)
        {
            colIpk.HeaderText = "IPK";
            colIpk.DefaultCellStyle.Format = "N2";
            colIpk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colIpk.FillWeight = 15;
        }
    }

    private void btnTambah_Click(object? sender, EventArgs e)
    {
        if (!ValidateInputForm(isNewStudent: true, out string nim, out string nama, out string prodi, out double ipk))
            return;

        daftarMahasiswa.Add(new Mahasiswa(nim, nama, prodi, ipk));
        ResetForm();
        UpdateStatus();

        MessageBox.Show("Data mahasiswa berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (dgvMahasiswa.CurrentRow?.DataBoundItem is not Mahasiswa selectedMhs)
        {
            MessageBox.Show("Pilih mahasiswa dari tabel yang ingin diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInputForm(isNewStudent: false, out _, out string nama, out string prodi, out double ipk))
            return;

        selectedMhs.Nama = nama;
        selectedMhs.Prodi = prodi;
        selectedMhs.IPK = ipk;

        dgvMahasiswa.Refresh();
        ResetForm();
        UpdateStatus();

        MessageBox.Show("Data mahasiswa berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnHapus_Click(object? sender, EventArgs e)
    {
        if (dgvMahasiswa.CurrentRow?.DataBoundItem is not Mahasiswa selectedMhs)
        {
            MessageBox.Show("Pilih baris mahasiswa yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult dialog = MessageBox.Show(
            $"Apakah Anda yakin ingin menghapus data mahasiswa:\n\nNRP  : {selectedMhs.NIM}\nNama : {selectedMhs.Nama}\nProdi: {selectedMhs.Prodi}?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (dialog == DialogResult.Yes)
        {
            daftarMahasiswa.Remove(selectedMhs);
            ResetForm();
            UpdateStatus();
            MessageBox.Show("Data mahasiswa berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnClear_Click(object? sender, EventArgs e)
    {
        ResetForm();
    }

    private void btnCari_Click(object? sender, EventArgs e)
    {
        LakukanPencarian();
    }

    private void txtCari_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            LakukanPencarian();
        }
    }

    private void LakukanPencarian()
    {
        string query = txtCari.Text.Trim();

        if (string.IsNullOrEmpty(query))
        {
            dgvMahasiswa.DataSource = daftarMahasiswa;
            UpdateStatus();
            return;
        }

        var hasil = daftarMahasiswa.Where(m =>
            m.NIM.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            m.Nama.Contains(query, StringComparison.OrdinalIgnoreCase) ||
            m.Prodi.Contains(query, StringComparison.OrdinalIgnoreCase)
        ).ToList();

        dgvMahasiswa.DataSource = new BindingList<Mahasiswa>(hasil);

        lblStatus.Text = $"Hasil Pencarian: {hasil.Count} data ditemukan untuk kata kunci \"{query}\"";

        if (hasil.Count == 0)
        {
            MessageBox.Show($"Tidak ditemukan data mahasiswa yang cocok dengan kata kunci \"{query}\".", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnRefresh_Click(object? sender, EventArgs e)
    {
        txtCari.Clear();
        dgvMahasiswa.DataSource = daftarMahasiswa;
        ResetForm();
        UpdateStatus();
    }

    private void dgvMahasiswa_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvMahasiswa.Rows.Count)
            return;

        if (dgvMahasiswa.Rows[e.RowIndex].DataBoundItem is Mahasiswa mhs)
        {
            txtNIM.Text = mhs.NIM;
            txtNama.Text = mhs.Nama;
            cmbProdi.Text = mhs.Prodi;
            txtIPK.Text = mhs.IPK.ToString("F2");

            SetEditMode(true);
        }
    }

    private void SetEditMode(bool isEditing)
    {
        errorProvider.Clear();
        txtNIM.ReadOnly = isEditing;
        btnTambah.Enabled = !isEditing;
        btnUpdate.Enabled = isEditing;
        btnHapus.Enabled = isEditing;

        if (isEditing)
        {
            txtNIM.BackColor = Color.FromArgb(241, 245, 249);
            btnTambah.BackColor = Color.FromArgb(148, 163, 184);
            btnUpdate.BackColor = Color.FromArgb(13, 148, 136);
            btnHapus.BackColor = Color.FromArgb(220, 38, 38);
        }
        else
        {
            txtNIM.BackColor = Color.White;
            btnTambah.BackColor = Color.FromArgb(37, 99, 235);
            btnUpdate.BackColor = Color.FromArgb(148, 163, 184);
            btnHapus.BackColor = Color.FromArgb(148, 163, 184);
        }
    }

    private void ResetForm()
    {
        errorProvider.Clear();
        txtNIM.Clear();
        txtNama.Clear();
        cmbProdi.SelectedIndex = -1;
        cmbProdi.Text = string.Empty;
        txtIPK.Clear();

        SetEditMode(false);
        dgvMahasiswa.ClearSelection();
        txtNIM.Focus();
    }

    private void UpdateStatus()
    {
        int total = daftarMahasiswa.Count;
        double avgIpk = total > 0 ? daftarMahasiswa.Average(m => m.IPK) : 0.0;

        lblStatus.Text = $"Total Mahasiswa: {total} orang   |   Rata-rata IPK: {avgIpk:F2}";
    }
}
