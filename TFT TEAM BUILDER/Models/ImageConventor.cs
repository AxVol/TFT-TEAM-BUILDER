using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Net;

namespace TFT_TEAM_BUILDER.Models
{
    class ImageConventor
    {
        private static BitmapSource bitmapSource;

        public static BitmapSource ConvertImage(Image image)
        {
            Bitmap bitmap = (Bitmap)Bitmap.FromFile($"Content\\champions\\{image.full}", true);
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
