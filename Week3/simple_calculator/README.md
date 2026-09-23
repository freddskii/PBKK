# Praktikum Week 3 PBKK — Simple Calculator

| Nama | NRP | Mata Kuliah | Kelas | 
| --- | --- | --- | --- | 
| Liem, Alfred Haryanto | 5025241100 | Pemrograman Berbasis Kerangka Kerja | D |

---

## 1. Deskripsi Project
Aplikasi kalkulator desktop GUI berbasis **C# Windows Forms App (.NET)** yang mengimplementasikan operasi aritmatika dasar (penjumlahan, pengurangan, perkalian, dan pembagian), penanganan desimal, reset/clear, penanganan pembagian nol (*divide by zero*), serta dukungan interaksi keyboard dan *modern responsive layout*.

---

## 2. Struktur Project
```text
simple_calculator
│
├── Program.cs                  # Entry point aplikasi & inisialisasi InvariantCulture
├── Form1.cs                    # Logika event handling kalkulator
├── Form1.Designer.cs           # Deklarasi komponen UI & susunan TableLayoutPanel
├── Form1.resx                  # Resource XML Windows Forms
├── simple_calculator.csproj    # File konfigurasi .NET SDK & Windows Forms
├── simple_calculator.csproj.user # Metadata visual designer VS
└── README.md                   # Dokumentasi praktikum & jawaban refleksi
```

---

## 3. Komponen & Desain UI
Layout disusun rapi menggunakan `TableLayoutPanel` dengan pola 4 kolom dan tombol "=" yang merentang di baris bawah:

| Control | Name | Text | Fungsi |
| :--- | :--- | :--- | :--- |
| Label | `lblTitle` | Calculator | Judul aplikasi |
| TextBox | `txtDisplay` | 0 | Layar display angka (Right-aligned) |
| Button | `btn7` | 7 | Input angka 7 |
| Button | `btn8` | 8 | Input angka 8 |
| Button | `btn9` | 9 | Input angka 9 |
| Button | `btnDivide` | ÷ | Operator Pembagian |
| Button | `btn4` | 4 | Input angka 4 |
| Button | `btn5` | 5 | Input angka 5 |
| Button | `btn6` | 6 | Input angka 6 |
| Button | `btnMultiply` | × | Operator Perkalian |
| Button | `btn1` | 1 | Input angka 1 |
| Button | `btn2` | 2 | Input angka 2 |
| Button | `btn3` | 3 | Input angka 3 |
| Button | `btnMinus` | − | Operator Pengurangan |
| Button | `btnClear` | C | Reset nilai kalkulator |
| Button | `btn0` | 0 | Input angka 0 |
| Button | `btnDecimal` | . | Titik desimal |
| Button | `btnPlus` | + | Operator Penjumlahan |
| Button | `btnEquals` | = | Eksekusi perhitungan hasil |

---

## 4. Implementasi Logika Utama

### A. State Variabel
- `double firstNumber`: Menyimpan operand pertama sebelum operator dipilih.
- `double secondNumber`: Menyimpan operand kedua saat tombol sama dengan ditekan.
- `double result`: Menyimpan hasil perhitungan akhir.
- `string operation`: Menyimpan lambang operasi yang sedang aktif (`+`, `−`, `×`, `÷`).

### B. Event Handler Bersama (Shared Handler)
Semua tombol angka `0`–`9` mengarah ke satu event handler `NumberButton_Click`:
```csharp
private void NumberButton_Click(object sender, EventArgs e)
{
    Button button = (Button)sender;
    if (txtDisplay.Text == "0")
        txtDisplay.Text = button.Text;
    else
        txtDisplay.Text += button.Text;
}
```

### C. Penanganan Error & Pembagian Nol
Pada tipe data floating point IEEE 754 (seperti `double` di C#), pembagian bilangan dengan nol menghasilkan nilai `Infinity` alih-alih melempar exception secara otomatis. Oleh karena itu, kita memvalidasi `secondNumber == 0` dan melempar `DivideByZeroException` agar tertangkap oleh blok `try-catch`:
```csharp
case "÷":
case "/":
    if (secondNumber == 0)
        throw new DivideByZeroException("Cannot divide by zero.");
    result = firstNumber / secondNumber;
    break;
```

---

## 5. Hasil Pengujian Skenario (Langkah 8)

| Skenario | Input | Expected Result | Status |
| :--- | :--- | :--- | :---: |
| **Penjumlahan** | `10 + 20 =` | `30` | ✅ Berhasil |
| **Pengurangan** | `30 − 12 =` | `18` | ✅ Berhasil |
| **Perkalian** | `6 × 7 =` | `42` | ✅ Berhasil |
| **Pembagian** | `100 ÷ 4 =` | `25` | ✅ Berhasil |
| **Desimal** | `2.5 × 4 =` | `10` | ✅ Berhasil |
| **Bagi Nol** | `10 ÷ 0 =` | Pesan error MessageBox ("Cannot divide by zero.") | ✅ Berhasil |
| **Clear** | Tekan `C` | `txtDisplay` kembali ke `0` dan variabel reset | ✅ Berhasil |

---

## 6. Jawaban Refleksi Mahasiswa

### 1. Apa fungsi `object sender` pada event handler?
**Jawaban:**  
Parameter `object sender` merepresentasikan referensi ke objek kontrol yang memicu (*firing*) event tersebut. Karena bertipe umum `object`, kita dapat melakukan *type casting* (misalnya `Button button = (Button)sender;`) untuk mengakses properti spesifik dari kontrol pemanggil, seperti properti `button.Text`. Hal ini memungkinkan kita menggunakan satu metode event handler yang sama untuk banyak kontrol sekaligus.

### 2. Mengapa semua tombol angka dapat memakai satu `NumberButton_Click`?
**Jawaban:**  
Karena alur logika yang dilakukan oleh setiap tombol angka (0–9) adalah identik: yaitu mengambil karakter angka dari tombol tersebut dan menambahkannya ke `txtDisplay`. Dengan memanfaatkan parameter `(Button)sender`, program secara dinamis mengetahui tombol angka mana yang diklik tanpa harus menuliskan 10 fungsi terpisah (*Don't Repeat Yourself / DRY principle*).

### 3. Apa perbedaan `firstNumber`, `secondNumber`, dan `result`?
**Jawaban:**  
- **`firstNumber`**: Menyimpan nilai angka yang pertama kali diketik oleh pengguna sebelum menekan tombol operator (+, −, ×, ÷).
- **`secondNumber`**: Menyimpan nilai angka kedua yang diketik setelah operator, yang diambil saat tombol sama dengan (`=`) ditekan.
- **`result`**: Menyimpan nilai kalkulasi akhir dari operasi aritmatika antara `firstNumber` dan `secondNumber` untuk kemudian ditampilkan kembali ke pengguna.

### 4. Mengapa pembagian dengan nol perlu divalidasi?
**Jawaban:**  
Secara matematis, pembagian dengan nol tidak terdefinisi (*undefined*). Pada bahasa C# dengan tipe data `double`, `x / 0` tidak melempar runtime exception secara default, melainkan menghasilkan `Infinity` atau `NaN`. Hal ini dapat merusak alur perhitungan selanjutnya. Validasi manual memastikan program mendeteksi operasi tak sah ini dan memberikan umpan balik yang informatif kepada pengguna melalui pesan error yang rapi.

### 5. Bagaimana `try-catch` membantu menjaga aplikasi tetap stabil?
**Jawaban:**  
Blok `try-catch` berfungsi sebagai mekanisme *exception handling* yang mencegat error tak terduga (seperti kesalahan parsing format teks `FormatException` atau pembagian dengan nol `DivideByZeroException`) sebelum mengakibatkan aplikasi mengalami *crash* (berhenti mendadak). Dengan menangkap exception di blok `catch`, aplikasi dapat menampilkan pesan peringatan yang ramah dan tetap berjalan normal.


# Contoh Dokumentasi:
1. Tampilan awal aplikasi

![Tampilan Awal Aplikasi](https://media.discordapp.net/attachments/1444914467510161450/1551796949169217556/7515E0FD-9E05-43D1-A84F-9859F87C41F3.png?ex=6ab3efc7&is=6ab29e47&hm=c4413df22b0e8591f654eada11546b667db0d9e4dd79acc8cdbb5b85393775e9&=&format=webp&quality=lossless)

2. Operasi perhitungan

![Penjumlahan](https://media.discordapp.net/attachments/1444914467510161450/1551797054215430237/DDB5810E-9B1D-48BF-B772-A7CDA4A6F621.png?ex=6ab3efe0&is=6ab29e60&hm=a3db6ce2f014d9cfc34cbba749abaf50cbf63a91d1885750682338b3be587512&=&format=webp&quality=lossless)

![Pengurangan](https://media.discordapp.net/attachments/1444914467510161450/1551798521605394452/EE9C478F-650F-4D4A-9AB1-38579F01D1A8.png?ex=6ab3f13e&is=6ab29fbe&hm=8c7645f97d0349a9fae3deee4c9e060f60e4666b9048f71d3278718cddf5f1f5&=&format=webp&quality=lossless)

![Perkalian](https://media.discordapp.net/attachments/1444914467510161450/1551798520594436137/EA0FB955-C887-41B4-8EFE-B16B77B51C0F.png?ex=6ab3f13e&is=6ab29fbe&hm=b674ec5f58db8c9599349e638dd7d3a6e1b89b044c159559dad25886139b15b9&=&format=webp&quality=lossless)

![Pembagian](https://media.discordapp.net/attachments/1444914467510161450/1551798522251182120/E1F0CAF3-31B2-4EBE-8FC3-46CF7C208737.png?ex=6ab3f13e&is=6ab29fbe&hm=fd9d2c2754f7683e527ebfcd4bd0013931be56a6ecd5ba937d392ef5fa1c8c6c&=&format=webp&quality=lossless)

3. Pembagian dengan 0

![Pembagian dengan 0](https://media.discordapp.net/attachments/1444914467510161450/1551798523207491665/7379F0D6-7A09-4AB0-B7C8-9BB4309A3A96.png?ex=6ab3f13e&is=6ab29fbe&hm=1bc67860fb3ee277304b194ec989edffdec319b11f74bb4aa7343f080f18c1f3&=&format=webp&quality=lossless)