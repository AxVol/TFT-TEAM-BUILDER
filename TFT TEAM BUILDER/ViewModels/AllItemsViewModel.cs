using System.Collections.ObjectModel;
using TFT_TEAM_BUILDER.Core;
using TFT_TEAM_BUILDER.Models;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class AllItemsViewModel : ObservableObject
    {
        public static ObservableCollection<Items> Items { get; set; }

        public AllItemsViewModel()
        {
            Items = new ObservableCollection<Items>(JsonData.GetItems());
        }
    }
}
