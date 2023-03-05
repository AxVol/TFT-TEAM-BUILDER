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
        public Commands loadBuildCommand { get; set; }
        public Commands deleteBuildCommand { get; set; }

        public MainViewModel mainViewModel { get; set; }
        public AllChampionsViewModel allChampionVM { get; set; }
        public AllItemsViewModel allItemsVM { get; set; }
        public CreateBuildViewModel createBuildVM { get; set; }
        public BuildViewModel BuildVM { get; set; }

        public ObservableCollection<Team> teamInfo { get; set; }

        public Team team { get; set; }

        private object currentView;
        private object checkBuild;

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
                return checkBuild;
            }
            set 
            {
                team = value as Team;

                checkBuild = value;
            }
        }

        private void LoadBuild(object buildTeam)
        {
            if (Build != null)
            {
                BuildViewModel.team = buildTeam as Team;
                CurrentView = BuildVM;
            }
        }
        private void DeleteBuild(object buildTeam)
        {
            if (Build != null)
            {
                Team build = buildTeam as Team;

                JsonData.DeleteBuild(build.name);

                teamInfo.Clear();
                teamInfo = new ObservableCollection<Team>(JsonData.GetTeamInfo());
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

            loadBuildCommand = new Commands(LoadBuild);
            deleteBuildCommand = new Commands(DeleteBuild);

            mainViewCommnd = new Commands(obj =>
            {
                teamInfo = new ObservableCollection<Team>(JsonData.GetTeamInfo());
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
