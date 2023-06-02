namespace DeskUniverse_Frontend.Models;

public class Board
{
    public int Id { get; set; }
    public int CampaignId { get; set; }
    public string Name { get; set; }
    public string? BackgroundURL { get; set; }
}