using DeskUniverse_Frontend.Models;

public class ItemService
{
    public Item ItemData { get; set; } = new Item();

    public void ItemSave(Item _Item)
    {   
        ItemData = _Item;
    }
}