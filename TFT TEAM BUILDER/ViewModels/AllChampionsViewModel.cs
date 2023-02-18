using System.Collections.ObjectModel;
using TFT_TEAM_BUILDER.Core;
using TFT_TEAM_BUILDER.Models;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class AllChampionsViewModel : ObservableObject
    {
        public ObservableCollection<Champions> champions { get; set; }

        public AllChampionsViewModel()
        {
            champions = new ObservableCollection<Champions>(JsonData.GetChampions());
        }
    }
}
