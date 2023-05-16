using DeskUniverse_Frontend.Models;

public class TokenService
{
    public Token TokenData { get; set; } = new Token();

    public void TokenSave(Token _Token)
    {
        TokenData = _Token;
    }
}