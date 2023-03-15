using DeskUniverse_Frontend.Models;

public class CharacterService
{
    public Character CharacterData { get; set; } = new Character();

    public void CharacterSave(Character _Character)
    {
        CharacterData = _Character;
    }
}
