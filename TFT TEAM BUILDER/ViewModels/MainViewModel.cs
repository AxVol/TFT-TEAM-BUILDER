using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFT_TEAM_BUILDER.Core;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public Commands allItemCommand { get; set; }
        public Commands allChampionsCommand { get; set; }

        public AllChampionsViewModel allChampionVM { get; set; }
        public AllItemsViewModel allItemsVM { get; set; }

        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            allChampionVM = new AllChampionsViewModel();
            allItemsVM = new AllItemsViewModel();

            allChampionsCommand = new Commands(obj =>
            {
                CurrentView = allChampionVM;
            });

            allItemCommand = new Commands(obj =>
            {
                CurrentView = allItemsVM;
            });
        }
    }
}
