namespace DeskUniverse_Frontend.Models;

public class Token
{
    public int Id { get; set; }
    public int? CampaignId { get; set; }
    public int CharacterId { get; set; }
    public string? ImageURL { get; set; }
    public string? Position { get; set; }
    public int? Health { get; set; }
    public int? Mana { get; set; }
}