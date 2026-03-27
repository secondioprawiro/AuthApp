# AuthBackend - API Autentikasi

Backend API untuk Sistem Login & Register sederhana, dibangun menggunakan **ASP.NET Core Web API 8**.

## 🛠️ Stack Teknologi
- **ASP.NET Core 8** (Minimal API / Controllers)
- **Entity Framework Core 8**
- **In-Memory Database** (Untuk testing)
- **Swagger / OpenAPI** (Untuk dokumentasi API)

## 📡 Endpoint API

### 1. Register
`POST /api/auth/register`
Mendaftarkan user baru dengan username dan password yang diberikan.

### 2. Login
`POST /api/auth/login`
Memverifikasi username dan password dari database.

## 🧪 Cara Menjalankan
Pastikan Anda berada di folder `AuthBackend`:
```powershell
dotnet run
```
Akses Dokumentasi API di: `https://localhost:7164/swagger` (atau http sesuai `launchSettings.json`).

## ⚙️ Konfigurasi Database
Aplikasi saat ini menggunakan **In-Memory Database** (Data tidak disimpan permanen di disk).
Ubah `Program.cs` jika ingin berpindah ke SQLite atau SQL Server.
