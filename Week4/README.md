# Student Management System - WPF MVVM

Tugas studi kasus membuat aplikasi manajemen data mahasiswa menggunakan WPF dengan pola MVVM, Data Binding, dan ADO.NET.

## Teknologi
- .NET 8, C#, WPF (XAML)
- MVVM Pattern
- ADO.NET + Microsoft.Data.SqlClient
- SQL Server LocalDB

## Struktur File
```
student_management_system_wps/
├── Student.cs           # Model mahasiswa (INotifyPropertyChanged)
├── StudentRepository.cs # Akses database ADO.NET (CRUD + Search)
├── RelayCommand.cs      # Implementasi ICommand
├── StudentViewModel.cs  # ViewModel (ObservableCollection, Command, Statistik)
├── MainWindow.xaml      # UI (Header, Form, Info Panel, Search, DataGrid)
└── MainWindow.xaml.cs   # DataContext = new StudentViewModel()
```

## Setup Database

Jalankan script SQL berikut di SQL Server LocalDB:

```sql
CREATE DATABASE StudentDB;
GO
USE StudentDB;
GO
CREATE TABLE Students (
    Id      INT IDENTITY(1,1) PRIMARY KEY,
    NIM     VARCHAR(20) NOT NULL,
    Nama    VARCHAR(100) NOT NULL,
    Jurusan VARCHAR(100) NOT NULL,
    Gender  VARCHAR(20) NOT NULL,
    Email   VARCHAR(100)
);
INSERT INTO Students (NIM, Nama, Jurusan, Gender, Email) VALUES
('23001','Budi Santoso','Informatika','Laki-laki','budi@gmail.com'),
('23002','Siti Aminah','Sistem Informasi','Perempuan','siti@gmail.com'),
('23003','Andi Wijaya','Informatika','Laki-laki','andi@gmail.com'),
('23004','Rina Sari','Sistem Informasi','Perempuan','rina@gmail.com');
```

## Cara Menjalankan

```
dotnet run
```

Pastikan SQL Server LocalDB sudah berjalan dan database `StudentDB` sudah dibuat.

## Fitur
- Tambah, ubah, hapus data mahasiswa (CRUD)
- Pencarian berdasarkan NIM, Nama, atau Jurusan
- Statistik otomatis (total, per jurusan, per gender)
- Pilih baris di tabel untuk edit/hapus

## Penjelasan Singkat (Cara Kerja)
Aplikasi ini memakai pola MVVM biar kodenya rapi dan terpisah:
1. **View**: Tampilannya dibikin pakai XAML (MainWindow.xaml). Semua form dan tombol di-binding (nyambung otomatis) ke ViewModel.
2. **ViewModel**: Di StudentViewModel.cs berisi logika aplikasi. Kalau tombol diklik (misal Simpan/Hapus), dia bakal manggil RelayCommand buat jalanin perintahnya ke Repository.
3. **Repository**: StudentRepository.cs ini yang ngurusin database. Dia ngirim query SQL (INSERT, UPDATE, DELETE, SELECT) ke SQL Server pakai ADO.NET.
4. **Model**: Student.cs cuma buat kerangka nyimpen data mahasiswa aja (Id, NIM, Nama, dll).
