using DeskUniverse_Frontend.Models;

public class BoardService
{
    public Board BoardData { get; set; } = new Board();

    public void BoardSave(Board _Board)
    {
        BoardData = _Board;
    }
}