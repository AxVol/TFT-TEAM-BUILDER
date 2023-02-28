using System.Windows.Media.Imaging;
using TFT_TEAM_BUILDER.Core;

namespace TFT_TEAM_BUILDER.Models
{
    class Traits : ObservableObject
    {
        private BitmapSource bitmapImage;

        public string id { get; set; }
        public string name { get; set; }
        public Image image { get; set; }
        public int teamCount { get; set; }
        public BitmapSource pathToImage
        {
            get
            {
                bitmapImage = ImageConventor.ConvertImage(image, "Content\\traits\\");

                return bitmapImage;
            }
        }
    }
}