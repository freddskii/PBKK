using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace sistem_data_mahasiswa;

public static class MahasiswaValidator
{
    public static (bool IsValid, string ErrorMessage) ValidateNRP(string? nrp)
    {
        if (string.IsNullOrWhiteSpace(nrp))
            return (false, "NRP tidak boleh kosong.");

        string trimmed = nrp.Trim();
        if (!Regex.IsMatch(trimmed, @"^\d+$"))
            return (false, "NRP hanya boleh berisi angka (tidak boleh ada huruf/simbol).");

        if (trimmed.Length != 10)
            return (false, $"NRP harus tepat 10 digit angka. Saat ini: {trimmed.Length} digit.");

        return (true, string.Empty);
    }

    public static (bool IsValid, string ErrorMessage) ValidateNama(string? nama)
    {
        if (string.IsNullOrWhiteSpace(nama))
            return (false, "Nama mahasiswa tidak boleh kosong.");

        string trimmed = nama.Trim();
        if (trimmed.Length < 3)
            return (false, "Nama mahasiswa minimal terdiri dari 3 karakter.");

        // Name only allows letters, spaces, dots, and apostrophes
        if (!Regex.IsMatch(trimmed, @"^[a-zA-Z\s\.\']+$"))
            return (false, "Nama hanya boleh berisi huruf, spasi, titik (.), dan petik ('). Angka dan simbol tidak diperbolehkan.");

        return (true, string.Empty);
    }

    public static (bool IsValid, string ErrorMessage) ValidateProdi(string? prodi)
    {
        if (string.IsNullOrWhiteSpace(prodi))
            return (false, "Program Studi wajib dipilih atau diisi.");

        string trimmed = prodi.Trim();
        if (trimmed.Length < 2)
            return (false, "Nama Program Studi minimal 2 karakter.");

        return (true, string.Empty);
    }

    public static (bool IsValid, double Value, string ErrorMessage) ValidateIPK(string? ipkStr)
    {
        if (string.IsNullOrWhiteSpace(ipkStr))
            return (false, 0, "IPK tidak boleh kosong.");

        // Support both comma and dot as decimal separator
        string normalized = ipkStr.Trim().Replace(',', '.');
        if (!double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out double val))
            return (false, 0, "IPK harus berupa angka desimal yang valid (contoh: 3.75).");

        if (val < 0.0 || val > 4.0)
            return (false, 0, $"IPK harus berada pada rentang 0.00 hingga 4.00. Nilai yang dimasukkan: {val:F2}");

        return (true, Math.Round(val, 2), string.Empty);
    }
}
