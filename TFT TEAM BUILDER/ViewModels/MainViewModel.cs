using System.Collections.ObjectModel;
using System.Reflection.Emit;
using TFT_TEAM_BUILDER.Core;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.ViewModels;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public Commands allItemCommand { get; set; }
        public Commands allChampionsCommand { get; set; }
        public Commands createBuildCommand { get; set; }
        public Commands mainViewCommnd { get; set; }

        public MainViewModel mainViewModel { get; set; }
        public AllChampionsViewModel allChampionVM { get; set; }
        public AllItemsViewModel allItemsVM { get; set; }
        public CreateBuildViewModel createBuildVM { get; set; }
        public BuildViewModel BuildVM { get; set; }

        public static ObservableCollection<Team> teamInfo { get; set; }

        private object currentView;
        private Team build;

        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public object Build
        {
            get 
            {  
                return build;
            }
            set 
            {
                build = value as Team;

                BuildViewModel.team = build;

                CurrentView = BuildVM; 
            }
        }

        public MainViewModel()
        {
            mainViewModel = this.mainViewModel;
            allChampionVM = new AllChampionsViewModel();
            allItemsVM = new AllItemsViewModel();
            createBuildVM = new CreateBuildViewModel();
            BuildVM = new BuildViewModel();
            teamInfo = new ObservableCollection<Team>(JsonData.GetTeamInfo());

            mainViewCommnd = new Commands(obj =>
            {
                CurrentView = mainViewModel;
            });
            
            allChampionsCommand = new Commands(obj =>
            {
                CurrentView = allChampionVM;
            });

            allItemCommand = new Commands(obj =>
            {
                CurrentView = allItemsVM;
            });

            createBuildCommand = new Commands(obj =>
            {
                CurrentView = createBuildVM;
            });
        }
    }
}
