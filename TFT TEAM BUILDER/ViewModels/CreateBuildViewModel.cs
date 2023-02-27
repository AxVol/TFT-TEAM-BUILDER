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
        public static ObservableCollection<Champions> offerList { get; set; }

        public ObservableCollection<Champions> slot0 { get; set; }
        public ObservableCollection<Champions> slot1 { get; set; }
        public ObservableCollection<Champions> slot2 { get; set; }
        public ObservableCollection<Champions> slot3 { get; set; }
        public ObservableCollection<Champions> slot4 { get; set; }
        public ObservableCollection<Champions> slot5 { get; set; }
        public ObservableCollection<Champions> slot6 { get; set; }
        public ObservableCollection<Champions> slot7 { get; set; }
        public ObservableCollection<Champions> slot8 { get; set; }
        public ObservableCollection<Champions> slot9 { get; set; }
        public ObservableCollection<Champions> slot10 { get; set; }
        public ObservableCollection<Champions> slot11 { get; set; }
        public ObservableCollection<Champions> slot12 { get; set; }
        public ObservableCollection<Champions> slot13 { get; set; }
        public ObservableCollection<Champions> slot14 { get; set; }
        public ObservableCollection<Champions> slot15 { get; set; }
        public ObservableCollection<Champions> slot16 { get; set; }
        public ObservableCollection<Champions> slot17 { get; set; }
        public ObservableCollection<Champions> slot18 { get; set; }
        public ObservableCollection<Champions> slot19 { get; set; }
        public ObservableCollection<Champions> slot20 { get; set; }
        public ObservableCollection<Champions> slot21 { get; set; }
        public ObservableCollection<Champions> slot22 { get; set; }
        public ObservableCollection<Champions> slot23 { get; set; }
        public ObservableCollection<Champions> slot24 { get; set; }
        public ObservableCollection<Champions> slot25 { get; set; }
        public ObservableCollection<Champions> slot26 { get; set; }
        public ObservableCollection<Champions> slot27 { get; set; }

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
            offerList = new ObservableCollection<Champions>();

            slot0 = new ObservableCollection<Champions>();
            slot1 = new ObservableCollection<Champions>();
            slot2 = new ObservableCollection<Champions>();
            slot3 = new ObservableCollection<Champions>();
            slot4 = new ObservableCollection<Champions>();
            slot5 = new ObservableCollection<Champions>();
            slot6 = new ObservableCollection<Champions>();
            slot7 = new ObservableCollection<Champions>();
            slot8 = new ObservableCollection<Champions>();
            slot9 = new ObservableCollection<Champions>();
            slot10 = new ObservableCollection<Champions>();
            slot11 = new ObservableCollection<Champions>();
            slot12 = new ObservableCollection<Champions>();
            slot13 = new ObservableCollection<Champions>();
            slot14 = new ObservableCollection<Champions>();
            slot15 = new ObservableCollection<Champions>();
            slot16 = new ObservableCollection<Champions>();
            slot17 = new ObservableCollection<Champions>();
            slot18 = new ObservableCollection<Champions>();
            slot19 = new ObservableCollection<Champions>();
            slot20 = new ObservableCollection<Champions>();
            slot21 = new ObservableCollection<Champions>();
            slot22 = new ObservableCollection<Champions>();
            slot23 = new ObservableCollection<Champions>();
            slot24 = new ObservableCollection<Champions>();
            slot25 = new ObservableCollection<Champions>();
            slot26 = new ObservableCollection<Champions>();
            slot27 = new ObservableCollection<Champions>();
        }

        public static void OfferList(Champions champion)
        {
            offerList.Add(champion);
        }
    }
}
