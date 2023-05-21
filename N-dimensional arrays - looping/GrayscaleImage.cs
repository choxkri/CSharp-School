public class GrayscaleImage
{
    public int Height { get; }
    public int Width { get; }
    //Set PixelData
    public int[,] PixelData { get; }
    public GrayscaleImage(int height, int width)
    {
        //Set Width, Height and PixelData
        Height = height; 
        Width = width;
        PixelData = new int[Height, Width];
    }

    public GrayscaleImage(int[,] pixelData)
    {
        //Set Width, Height and PixelData
        PixelData = pixelData;
        Height = pixelData.GetLength(0);
        Width = pixelData.GetLength(1);
    }
}