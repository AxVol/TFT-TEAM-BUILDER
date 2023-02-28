using System;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows;

namespace TFT_TEAM_BUILDER.Models
{
    class ImageConventor
    {
        private static BitmapSource bitmapSource;

        public static BitmapSource ConvertImage(Image image, string path)
        {
            Bitmap bitmap = (Bitmap)Bitmap.FromFile($"{path}{image.full}", true);
            bitmapSource = BitmapToBitmapSource(bitmap);

            return bitmapSource;
        }

        private static BitmapSource BitmapToBitmapSource(Bitmap source)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                          source.GetHbitmap(),
                          IntPtr.Zero,
                          Int32Rect.Empty,
                          BitmapSizeOptions.FromEmptyOptions());
        }
    }
}
