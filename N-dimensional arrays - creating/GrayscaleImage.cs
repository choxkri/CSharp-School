public class GrayscaleImage
{
    public int Height { get; }
    public int Width { get; }
    //Set PixelData
    public int[,] PixelData { get; }
    public GrayscaleImage(int height, int width)
    {
        //Set Width, Height and PixelData
        this.Height = height;
        this.Width = width;
        PixelData = new int[Height, Width];
    }

    public GrayscaleImage(int[,] pixelData)
    {
        //Set Width, Height and PixelData
        PixelData = pixelData;
        this.Height = pixelData.GetLength(0);
        this.Width = pixelData.GetLength(1);
    }

    public void AdjustBrightness(double factor)
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                PixelData[i, j] = (int)((double)PixelData[i, j] * factor);
            }
        }
    }
}