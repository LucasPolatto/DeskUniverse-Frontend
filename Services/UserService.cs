public class UserService
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool Logado { get; set; } = false;

    // Desloga o usuário --------------------------------------------------------------------------------------------------------------
    public void LogOut()
    {
        Id = 0;
        Username = null;
        Logado = false;
    }
}