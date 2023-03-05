using System;
using System.Drawing;
using System.IO;

namespace ImageProcessing
{
    class Program
    {
        static void Main(string[] args)
        {

            Bitmap image1 = new Bitmap(@"C:\Users\User\Pictures\Screenshots\image1.png");
            Bitmap image2 = new Bitmap(@"C:\Users\User\Pictures\Screenshots\image2.png");
            Bitmap image3 = new Bitmap(@"C:\Users\User\Pictures\Screenshots\image3.png");


            Func<Bitmap, Bitmap> invertColors = bitmap =>
            {
                Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        Color color = bitmap.GetPixel(x, y);
                        newBitmap.SetPixel(x, y, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                    }
                }
                return newBitmap;
            };
            Func<Bitmap, Bitmap> grayscale = bitmap =>
            {
                Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        Color color = bitmap.GetPixel(x, y);
                        int grayValue = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                        newBitmap.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                    }
                }
                return newBitmap;
            };


            Action<Bitmap> displayImage = bitmap =>
            {
                bitmap.Save(@"output.png");
                Console.WriteLine("Зображення оброблено та збережено в файлі output.png");
            };


            displayImage(invertColors(image1));
            displayImage(grayscale(image2));
            displayImage(invertColors(grayscale(image3)));
        }
    }
}