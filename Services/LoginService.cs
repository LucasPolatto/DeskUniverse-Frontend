public class LoginService
{
    public int Id { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }
    public bool Logado { get; set; } = false;
}