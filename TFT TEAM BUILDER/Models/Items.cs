using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TFT_TEAM_BUILDER.ViewModels;

namespace TFT_TEAM_BUILDER.Models
{
    class Items
    {
        private BitmapSource bitmapImage;
        private BitmapSource firstItem;
        private BitmapSource secondItem;

        public string id { get; set; }
        public string name { get; set; }
        public string[] craft { get; set; }
        public Image image { get; set; }

        public BitmapSource pathToImage
        {
            get
            {
                bitmapImage = ImageConventor.ConvertImage(image, "Content\\items\\");

                return bitmapImage;
            }
        }

        public BitmapSource FirstItem
        {
            get
            {
                try
                {
                    foreach (Items item in AllItemsViewModel.Items)
                    {
                        if (item.name == craft[0])
                        {
                            firstItem = ImageConventor.ConvertImage(item.image, "Content\\items\\");
                            return firstItem;
                        }
                    }
                }
                catch
                {
                    return pathToImage;
                }
                return null;
            }
        }

        public BitmapSource SecondItem
        {
            get
            {
                try
                {
                    foreach (Items item in AllItemsViewModel.Items)
                    {
                        if (item.name == craft[1])
                        {
                            secondItem = ImageConventor.ConvertImage(item.image, "Content\\items\\");
                            return secondItem;
                        }
                    }
                }
                catch
                {
                    return null;
                }
                return null;
            }
        }
    }
}