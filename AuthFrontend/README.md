# AuthFrontend - UI Autentikasi

Frontend aplikasi autentikasi yang dibangun menggunakan **Blazor WebAssembly 8**.

## 🛠️ Stack Teknologi
- **Blazor WebAssembly 8**
- **HttpClient** (Untuk komunikasi API)
- **C# / Razor Components**
- **Vanila CSS Styling** (Inline styles)

## 📄 Halaman

### 1. Home / Login (`/`)
Halaman login dengan validasi hingga 3 kali percobaan gagal.

### 2. Register (`/register`)
Halaman pendaftaran user baru. Jika sukses, akan dialihkan ke halaman Login.

### 3. Welcome (`/welcome`)
Halaman sukses setelah login berhasil.

### 4. Lock Screen (`/lockscreen`)
Halaman terkunci jika user salah memasukkan password lebih dari 3 kali.

## 🧪 Cara Menjalankan
Pastikan Anda berada di folder `AuthFrontend`:
```powershell
dotnet run
```
Aplikasi akan secara otomatis terhubung ke Backend di `https://localhost:7164` (atur `BaseAddress` di `Program.cs` jika port backend Anda berbeda).

## 🚀 Fitur Frontend
- Binding data `@bind`.
- Navigasi dinamis `NavigationManager`.
- Penanganan state sederhana (login failed counter).
