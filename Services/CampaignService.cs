using DeskUniverse_Frontend.Models;

public class CampaignService
{
    public Campaign CampaignData { get; set; } = new Campaign();

    public void CampaignSave(Campaign _Campaign)
    {
        CampaignData = _Campaign;
    }
}
