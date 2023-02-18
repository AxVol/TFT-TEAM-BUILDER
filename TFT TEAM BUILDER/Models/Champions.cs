using System.Windows.Media.Imaging;

namespace TFT_TEAM_BUILDER.Models
{
    class Champions
    {
        private BitmapSource bitmapImage;

        public string id { get; set; }
        public string name { get; set; }
        public int tier { get; set; }
        public Image image { get; set; }
        public string[] traits { get; set; } 

        public BitmapSource pathToImage
        {
            get 
            {
                bitmapImage = ImageConventor.ConvertImage(image);

                return bitmapImage;
            } 
        }
    }
}
