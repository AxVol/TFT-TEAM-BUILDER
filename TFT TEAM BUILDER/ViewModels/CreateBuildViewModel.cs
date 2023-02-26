using System.Collections.ObjectModel;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.Core;
using GongSolutions.Wpf.DragDrop;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class CreateBuildViewModel : ObservableObject
    {
        private static IDropTarget instance;
        public static IDropTarget Instance => instance = new ChromerDragDrop();

        private string text;

        public ObservableCollection<Champions> champions { get; set; }
        public ObservableCollection<Champions> sortList { get; set; }
        public ObservableCollection<Champions> slot0 { get; set; }
        public ObservableCollection<Champions> slot1 { get; set; }

        public string SortEvent {
            get
            {
                return text;
            }
            set
            {
                text = value;

                sortList.Clear();

                foreach (Champions champion in champions)
                {
                    if (champion.name.ToLower().StartsWith(text.ToLower()))
                    {
                        sortList.Add(champion);
                    }
                }
            } 
        }

        public CreateBuildViewModel()
        {
            sortList = new ObservableCollection<Champions>(JsonData.GetChampions());
            champions = new ObservableCollection<Champions>(JsonData.GetChampions());
            slot0 = new ObservableCollection<Champions>();
            slot1 = new ObservableCollection<Champions>();
        }
    }
}
