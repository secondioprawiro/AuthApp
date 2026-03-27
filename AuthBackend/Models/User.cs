namespace AuthBackend.Models
{
    public class User{
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class AuthRequest{
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class AuthResponse{
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}

