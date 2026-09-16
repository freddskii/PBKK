# Latihan 1 PBKK

| Nama | NRP | Mata Kuliah | Kelas | 
| --- | --- | --- | --- | 
| Liem, Alfred Haryanto | 5025241100 | Pemrograman Berbasis Kerangka Kerja | D |


## 1. Hello World Console

Pada bagian pertama ini bertujuan untuk membuat program simple yang akan melakukan print "Hello World!" pada console, adapun langkah-langkah nya sebagai berikut:

### Build & Run
1. Inisialisasi project console:
```bash
dotnet new console -n HelloWorld 
```

2. Masuk ke folder project dan jalankan:
```bash
cd HelloWorld
dotnet run
```

![Dokumentasi Terminal](https://media.discordapp.net/attachments/1444914467510161450/1549594490048610355/B7D7E8D1-5CDC-4DAE-9864-DAE207FFC0E4.png?ex=6aab43d4&is=6aa9f254&hm=b6e6f4792c549086acf3c6c5287ccdaceb6238888d6bd134d843222be4847b4f&=&format=webp&quality=lossless)

## 2. Sistem Data Mahasiswa (Desktop GUI)

Pada bagian kedua ini bertujuan untuk membuat desktop app sederhana menggunakan **C# Windows Forms**. App yang dibuat adalah CRUD data mahasiswa, meliputi menambah data, mengubah data, menghapus data, dan membaca data. Berikut merupakan langkah-langkah dalam membuat app tersebut:

### Build dan Inisialisasi
1. Inisialisasi project winforms:
```bash
dotnet new winforms -n sistem_data_mahasiswa 
```

2. Masuk ke folder project:
```bash
cd sistem_data_mahasiswa
dotnet run
```


### Fitur Utama
- **Form Input Sidebar** → Panel kiri untuk input data mahasiswa (NRP, Nama, Prodi, IPK).
- **Tabel Data Interactive** → Panel kanan menampilkan daftar mahasiswa dengan `DataGridView` berdesain Dark Mode modern.
- **Auto-Fill Input** → Klik baris tabel, data otomatis masuk kembali ke form input sidebar.
- **Pencarian & Penghapusan** → Cari data berdasarkan NIM/NRP atau hapus data dengan dialog konfirmasi.
- **Validasi Data Menyeluruh** → Validasi NRP (tepat 10 digit angka), Nama (hanya huruf & spasi, minimal 3 karakter), Prodi, dan IPK (rentang 0.00 – 4.00) dengan pembatasan langsung saat mengetik (`KeyPress`).

### Tampilan Aplikasi
1. Tampilan Awal

![Tampilan Awal Aplikasi](https://media.discordapp.net/attachments/1444914467510161450/1549658573401755769/F0289836-1598-476A-93EF-50C6D1387ED9.png?ex=6aab7f83&is=6aaa2e03&hm=1cc1ede4c92bb6b22289a16d0901d50b1465147c6b3a00308111bcbf40497a31&=&format=webp&quality=lossless)

2. Tambahkan Data

![Tambah Data Mahasiswa](https://media.discordapp.net/attachments/1444914467510161450/1549658543886700735/5AB423CD-D51C-41BE-8C9E-83ADD8483BDC.png?ex=6aab7f7c&is=6aaa2dfc&hm=c6caa321af371c87b6a540c1c6c4edcb49a8ca37ca9217a797fa87699f34e620&=&format=webp&quality=lossless)

3. Mencari Data

![Mencari Data Mahasiswa](https://media.discordapp.net/attachments/1444914467510161450/1549658800993083462/2B40E005-C470-4B09-8D9E-FB8D27838793.png?ex=6aab7fb9&is=6aaa2e39&hm=f758e85199e0637af65aa1b9e23d37abf6c61d6ce3192ba9cd0242d3e33772da&=&format=webp&quality=lossless)

4. Menghapus Data

Dapat dilihat data mahasiswa dengan NIM `5025241100` telah dihapus dari tabel
![Menghapus Data Mahasiswa](https://media.discordapp.net/attachments/1444914467510161450/1549659419179229265/192EDF70-992D-41BA-9F27-9148A44D7A97.png?ex=6aab804c&is=6aaa2ecc&hm=c7cfdc6cc9e6b4322bfc1e9954bbe69e09924cc3240baa69b5915f5849d07721&=&format=webp&quality=lossless)

![Data Mahasiswa Berhasil Dihapus](https://media.discordapp.net/attachments/1444914467510161450/1549659442323136512/4B1F558A-BFF6-4CD1-B617-A8A7923DD5F0.png?ex=6aab8052&is=6aaa2ed2&hm=c4e1529af3e090639a582c0de31ef97188476e575f032f8bd2723c531f48cc65&=&format=webp&quality=lossless)


5. Akan muncul pesan / peringatan apabila input yang diberikan tidak valid atau tidak sesuai

![Input Tidak Lengkap](https://media.discordapp.net/attachments/1444914467510161450/1549660583291256852/505636E0-B370-43C9-9D3A-A837048B76C2.png?ex=6aab8162&is=6aaa2fe2&hm=2e180c7692984a73b08196c3d38208e220b0ddcc4c807da12a56aac01b0cbda3&=&format=webp&quality=lossless)