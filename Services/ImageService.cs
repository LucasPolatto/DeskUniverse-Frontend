using DeskUniverse_Frontend.Models;

public class ImageService
{
    public Image ImageData { get; set; } = new Image();

    public void ImageSave(Image _Image)
    {   
        ImageData = _Image;
    }
}