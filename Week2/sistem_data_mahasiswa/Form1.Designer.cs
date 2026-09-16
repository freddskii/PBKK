namespace sistem_data_mahasiswa;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dgvRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dgvAltRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

        pnlHeader = new System.Windows.Forms.Panel();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();

        pnlSidebar = new System.Windows.Forms.Panel();
        grpInput = new System.Windows.Forms.GroupBox();
        lblNIM = new System.Windows.Forms.Label();
        txtNIM = new System.Windows.Forms.TextBox();
        lblNama = new System.Windows.Forms.Label();
        txtNama = new System.Windows.Forms.TextBox();
        lblProdi = new System.Windows.Forms.Label();
        cmbProdi = new System.Windows.Forms.ComboBox();
        lblIPK = new System.Windows.Forms.Label();
        txtIPK = new System.Windows.Forms.TextBox();

        btnTambah = new System.Windows.Forms.Button();
        btnUpdate = new System.Windows.Forms.Button();
        btnHapus = new System.Windows.Forms.Button();
        btnClear = new System.Windows.Forms.Button();

        pnlContent = new System.Windows.Forms.Panel();
        pnlSearch = new System.Windows.Forms.Panel();
        lblCari = new System.Windows.Forms.Label();
        txtCari = new System.Windows.Forms.TextBox();
        btnCari = new System.Windows.Forms.Button();
        btnRefresh = new System.Windows.Forms.Button();

        dgvMahasiswa = new System.Windows.Forms.DataGridView();
        pnlStatus = new System.Windows.Forms.Panel();
        lblStatus = new System.Windows.Forms.Label();

        errorProvider = new System.Windows.Forms.ErrorProvider(components);

        pnlHeader.SuspendLayout();
        pnlSidebar.SuspendLayout();
        grpInput.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).BeginInit();
        pnlStatus.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();

        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
        pnlHeader.Size = new System.Drawing.Size(1020, 75);
        pnlHeader.TabIndex = 0;

        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTitle.ForeColor = System.Drawing.Color.White;
        lblTitle.Location = new System.Drawing.Point(18, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(262, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Sistem Data Mahasiswa";

        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        lblSubtitle.Location = new System.Drawing.Point(20, 44);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(340, 17);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Manajemen data akademik & rekap IPK mahasiswa";

        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlSidebar.Controls.Add(grpInput);
        pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        pnlSidebar.Location = new System.Drawing.Point(0, 75);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Padding = new System.Windows.Forms.Padding(16);
        pnlSidebar.Size = new System.Drawing.Size(330, 565);
        pnlSidebar.TabIndex = 1;

        // 
        // grpInput
        // 
        grpInput.BackColor = System.Drawing.Color.White;
        grpInput.Controls.Add(lblNIM);
        grpInput.Controls.Add(txtNIM);
        grpInput.Controls.Add(lblNama);
        grpInput.Controls.Add(txtNama);
        grpInput.Controls.Add(lblProdi);
        grpInput.Controls.Add(cmbProdi);
        grpInput.Controls.Add(lblIPK);
        grpInput.Controls.Add(txtIPK);
        grpInput.Controls.Add(btnTambah);
        grpInput.Controls.Add(btnUpdate);
        grpInput.Controls.Add(btnHapus);
        grpInput.Controls.Add(btnClear);
        grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
        grpInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        grpInput.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        grpInput.Location = new System.Drawing.Point(16, 16);
        grpInput.Name = "grpInput";
        grpInput.Padding = new System.Windows.Forms.Padding(16);
        grpInput.Size = new System.Drawing.Size(298, 533);
        grpInput.TabIndex = 0;
        grpInput.TabStop = false;
        grpInput.Text = " Form Input Data ";

        // 
        // lblNIM
        // 
        lblNIM.AutoSize = true;
        lblNIM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblNIM.Location = new System.Drawing.Point(16, 32);
        lblNIM.Name = "lblNIM";
        lblNIM.Size = new System.Drawing.Size(95, 15);
        lblNIM.TabIndex = 0;
        lblNIM.Text = "NRP (10 angka) :";

        // 
        // txtNIM
        // 
        txtNIM.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtNIM.Location = new System.Drawing.Point(16, 52);
        txtNIM.MaxLength = 10;
        txtNIM.Name = "txtNIM";
        txtNIM.PlaceholderText = "10 digit angka (cth: 5025211001)";
        txtNIM.Size = new System.Drawing.Size(250, 24);
        txtNIM.TabIndex = 1;

        // 
        // lblNama
        // 
        lblNama.AutoSize = true;
        lblNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblNama.Location = new System.Drawing.Point(16, 88);
        lblNama.Name = "lblNama";
        lblNama.Size = new System.Drawing.Size(93, 15);
        lblNama.TabIndex = 2;
        lblNama.Text = "Nama Lengkap :";

        // 
        // txtNama
        // 
        txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtNama.Location = new System.Drawing.Point(16, 108);
        txtNama.MaxLength = 100;
        txtNama.Name = "txtNama";
        txtNama.PlaceholderText = "Nama tanpa angka (cth: Budi)";
        txtNama.Size = new System.Drawing.Size(250, 24);
        txtNama.TabIndex = 3;

        // 
        // lblProdi
        // 
        lblProdi.AutoSize = true;
        lblProdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblProdi.Location = new System.Drawing.Point(16, 144);
        lblProdi.Name = "lblProdi";
        lblProdi.Size = new System.Drawing.Size(89, 15);
        lblProdi.TabIndex = 4;
        lblProdi.Text = "Program Studi :";

        // 
        // cmbProdi
        // 
        cmbProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
        cmbProdi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        cmbProdi.FormattingEnabled = true;
        cmbProdi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Sistem Informasi",
            "Teknologi Informasi",
            "Sains Data",
            "Teknik Komputer",
            "Rekayasa Perangkat Lunak"
        });
        cmbProdi.Location = new System.Drawing.Point(16, 164);
        cmbProdi.Name = "cmbProdi";
        cmbProdi.Size = new System.Drawing.Size(250, 24);
        cmbProdi.TabIndex = 5;

        // 
        // lblIPK
        // 
        lblIPK.AutoSize = true;
        lblIPK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblIPK.Location = new System.Drawing.Point(16, 200);
        lblIPK.Name = "lblIPK";
        lblIPK.Size = new System.Drawing.Size(95, 15);
        lblIPK.TabIndex = 6;
        lblIPK.Text = "IPK (0.00 - 4.00) :";

        // 
        // txtIPK
        // 
        txtIPK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtIPK.Location = new System.Drawing.Point(16, 220);
        txtIPK.MaxLength = 5;
        txtIPK.Name = "txtIPK";
        txtIPK.PlaceholderText = "Contoh: 3.75";
        txtIPK.Size = new System.Drawing.Size(250, 24);
        txtIPK.TabIndex = 7;

        // 
        // btnTambah
        // 
        btnTambah.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTambah.FlatAppearance.BorderSize = 0;
        btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTambah.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnTambah.ForeColor = System.Drawing.Color.White;
        btnTambah.Location = new System.Drawing.Point(16, 270);
        btnTambah.Name = "btnTambah";
        btnTambah.Size = new System.Drawing.Size(250, 36);
        btnTambah.TabIndex = 8;
        btnTambah.Text = "+ Tambah Mahasiswa";
        btnTambah.UseVisualStyleBackColor = false;

        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = System.Drawing.Color.FromArgb(13, 148, 136);
        btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
        btnUpdate.FlatAppearance.BorderSize = 0;
        btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnUpdate.ForeColor = System.Drawing.Color.White;
        btnUpdate.Location = new System.Drawing.Point(16, 314);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new System.Drawing.Size(250, 36);
        btnUpdate.TabIndex = 9;
        btnUpdate.Text = "✏ Simpan Perubahan";
        btnUpdate.UseVisualStyleBackColor = false;

        // 
        // btnHapus
        // 
        btnHapus.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
        btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
        btnHapus.FlatAppearance.BorderSize = 0;
        btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHapus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnHapus.ForeColor = System.Drawing.Color.White;
        btnHapus.Location = new System.Drawing.Point(16, 358);
        btnHapus.Name = "btnHapus";
        btnHapus.Size = new System.Drawing.Size(250, 36);
        btnHapus.TabIndex = 10;
        btnHapus.Text = "🗑 Hapus Mahasiswa";
        btnHapus.UseVisualStyleBackColor = false;

        // 
        // btnClear
        // 
        btnClear.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        btnClear.ForeColor = System.Drawing.Color.White;
        btnClear.Location = new System.Drawing.Point(16, 402);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(250, 34);
        btnClear.TabIndex = 11;
        btnClear.Text = "🔄 Reset Form";
        btnClear.UseVisualStyleBackColor = false;

        // 
        // pnlContent
        // 
        pnlContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        pnlContent.Controls.Add(dgvMahasiswa);
        pnlContent.Controls.Add(pnlSearch);
        pnlContent.Controls.Add(pnlStatus);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(330, 75);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(16);
        pnlContent.Size = new System.Drawing.Size(690, 565);
        pnlContent.TabIndex = 2;

        // 
        // pnlSearch
        // 
        pnlSearch.BackColor = System.Drawing.Color.White;
        pnlSearch.Controls.Add(lblCari);
        pnlSearch.Controls.Add(txtCari);
        pnlSearch.Controls.Add(btnCari);
        pnlSearch.Controls.Add(btnRefresh);
        pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
        pnlSearch.Location = new System.Drawing.Point(16, 16);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Padding = new System.Windows.Forms.Padding(12);
        pnlSearch.Size = new System.Drawing.Size(658, 54);
        pnlSearch.TabIndex = 0;

        // 
        // lblCari
        // 
        lblCari.AutoSize = true;
        lblCari.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblCari.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblCari.Location = new System.Drawing.Point(12, 17);
        lblCari.Name = "lblCari";
        lblCari.Size = new System.Drawing.Size(69, 17);
        lblCari.TabIndex = 0;
        lblCari.Text = "Cari Data:";

        // 
        // txtCari
        // 
        txtCari.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtCari.Location = new System.Drawing.Point(88, 14);
        txtCari.Name = "txtCari";
        txtCari.PlaceholderText = "Ketik NRP atau Nama...";
        txtCari.Size = new System.Drawing.Size(280, 24);
        txtCari.TabIndex = 1;

        // 
        // btnCari
        // 
        btnCari.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCari.FlatAppearance.BorderSize = 0;
        btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnCari.ForeColor = System.Drawing.Color.White;
        btnCari.Location = new System.Drawing.Point(376, 12);
        btnCari.Name = "btnCari";
        btnCari.Size = new System.Drawing.Size(85, 28);
        btnCari.TabIndex = 2;
        btnCari.Text = "🔍 Cari";
        btnCari.UseVisualStyleBackColor = false;

        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
        btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        btnRefresh.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        btnRefresh.Location = new System.Drawing.Point(468, 12);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new System.Drawing.Size(120, 28);
        btnRefresh.TabIndex = 3;
        btnRefresh.Text = "Tampilkan Semua";
        btnRefresh.UseVisualStyleBackColor = false;

        // 
        // dgvMahasiswa
        // 
        dgvMahasiswa.AllowUserToAddRows = false;
        dgvMahasiswa.AllowUserToDeleteRows = false;
        dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvMahasiswa.BackgroundColor = System.Drawing.Color.White;
        dgvMahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvMahasiswa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvMahasiswa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

        dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        dgvHeaderStyle.ForeColor = System.Drawing.Color.White;
        dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(8);
        dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvHeaderStyle.SelectionForeColor = System.Drawing.Color.White;
        dgvMahasiswa.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvMahasiswa.ColumnHeadersHeight = 40;
        dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        dgvRowStyle.BackColor = System.Drawing.Color.White;
        dgvRowStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        dgvRowStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvRowStyle.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
        dgvRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
        dgvRowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
        dgvMahasiswa.DefaultCellStyle = dgvRowStyle;

        dgvAltRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dgvAltRowStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        dgvAltRowStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dgvAltRowStyle.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
        dgvAltRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
        dgvAltRowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
        dgvMahasiswa.AlternatingRowsDefaultCellStyle = dgvAltRowStyle;

        dgvMahasiswa.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvMahasiswa.EnableHeadersVisualStyles = false;
        dgvMahasiswa.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvMahasiswa.Location = new System.Drawing.Point(16, 82);
        dgvMahasiswa.MultiSelect = false;
        dgvMahasiswa.Name = "dgvMahasiswa";
        dgvMahasiswa.ReadOnly = true;
        dgvMahasiswa.RowHeadersVisible = false;
        dgvMahasiswa.RowTemplate.Height = 36;
        dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvMahasiswa.Size = new System.Drawing.Size(658, 417);
        dgvMahasiswa.TabIndex = 1;

        // 
        // pnlStatus
        // 
        pnlStatus.BackColor = System.Drawing.Color.White;
        pnlStatus.Controls.Add(lblStatus);
        pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlStatus.Location = new System.Drawing.Point(16, 509);
        pnlStatus.Name = "pnlStatus";
        pnlStatus.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        pnlStatus.Size = new System.Drawing.Size(658, 40);
        pnlStatus.TabIndex = 2;

        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblStatus.Location = new System.Drawing.Point(10, 12);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(225, 15);
        lblStatus.TabIndex = 0;
        lblStatus.Text = "Total Mahasiswa: 0 | Rata-rata IPK: 0.00";

        // 
        // errorProvider
        // 
        errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        errorProvider.ContainerControl = this;

        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        ClientSize = new System.Drawing.Size(1020, 640);
        Controls.Add(pnlContent);
        Controls.Add(pnlSidebar);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        MinimumSize = new System.Drawing.Size(900, 550);
        Name = "Form1";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Sistem Data Mahasiswa - PBKK";

        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlSidebar.ResumeLayout(false);
        grpInput.ResumeLayout(false);
        grpInput.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).EndInit();
        pnlStatus.ResumeLayout(false);
        pnlStatus.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.GroupBox grpInput;
    private System.Windows.Forms.Label lblNIM;
    private System.Windows.Forms.TextBox txtNIM;
    private System.Windows.Forms.Label lblNama;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.Label lblProdi;
    private System.Windows.Forms.ComboBox cmbProdi;
    private System.Windows.Forms.Label lblIPK;
    private System.Windows.Forms.TextBox txtIPK;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.Panel pnlSearch;
    private System.Windows.Forms.Label lblCari;
    private System.Windows.Forms.TextBox txtCari;
    private System.Windows.Forms.Button btnCari;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.DataGridView dgvMahasiswa;
    private System.Windows.Forms.Panel pnlStatus;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ErrorProvider errorProvider;
}
