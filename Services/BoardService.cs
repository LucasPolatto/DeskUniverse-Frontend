using DeskUniverse_Frontend.Models;

public class BoardService
{
    public bool Playing = false;
    public Board BoardData { get; set; } = new Board();

    public void BoardSave(Board _Board)
    {
        BoardData = _Board;
    }
}