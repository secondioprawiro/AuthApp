# AuthApp - Proyek Sistem Login & Register

Proyek ini adalah implementasi sistem autentikasi sederhana menggunakan **ASP.NET Core Web API 8** sebagai Backend dan **Blazor WebAssembly 8** sebagai Frontend.

## 📁 Struktur Proyek
- **AuthBackend**: API untuk menangani registrasi, login, dan penyimpanan user sementara (In-Memory Database).
- **AuthFrontend**: Antarmuka pengguna (UI) yang dibangun dengan Blazor untuk interaksi registrasi dan login.

## 🚀 Cara Menjalankan Aplikasi

### 1. Jalankan Backend (API)
Pindah ke folder backend dan jalankan perintah:
```powershell
cd AuthBackend
dotnet run
```
Aplikasi backend akan berjalan di `https://localhost:7164` (cek `launchSettings.json`).

### 2. Jalankan Frontend (Blazor)
Buka terminal baru, pindah ke folder frontend dan jalankan perintah:
```powershell
cd AuthFrontend
dotnet run
```
Aplikasi frontend akan berjalan di browser (cek `launchSettings.json` atau CLI output).

## 🛠️ Fitur
- [x] Registrasi User Baru (Validasi duplikasi username).
- [x] Login User (Validasi keberadaan user).
- [x] Counter Login Gagal (Maksimal 3 kali percobaan sebelum terkunci).
- [x] Welcome Screen (Setelah login sukses).
- [x] Lock Screen (Jika gagal login 3 kali).

## 🗃️ Database
Proyek ini saat ini menggunakan **EF Core In-Memory Database** untuk tujuan pengujian. Data akan hilang setiap kali aplikasi Backend dimatikan.
