using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using TFT_TEAM_BUILDER.Core;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.ViewModels;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class MainViewModel : ObservableObject
    {
        // Команды для навигации по страницам
        public Commands allItemCommand { get; set; }
        public Commands allChampionsCommand { get; set; }
        public Commands createBuildCommand { get; set; }
        public Commands mainViewCommnd { get; set; }
        public Commands loadBuildCommand { get; set; }
        public Commands deleteBuildCommand { get; set; }
        public Commands editBuildCommand { get; set; }

        public MainViewModel mainVM { get; set; }
        public AllChampionsViewModel allChampionVM { get; set; }
        public AllItemsViewModel allItemsVM { get; set; }
        public CreateBuildViewModel createBuildVM { get; set; }
        public BuildViewModel BuildVM { get; set; }

        public ObservableCollection<Team> teamInfo { get; set; }
        // поле для связи информации о команде между вью моделями
        public Team team { get; set; }

        private object currentView;
        private object selectedBuild;

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
                return selectedBuild;
            }
            set 
            {
                team = value as Team;

                selectedBuild = value;
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
        private void EditBuild(object buildTeam)
        {
            if (Build != null)
            {
                Team teamStat = buildTeam as Team;

                CreateBuildViewModel.team = teamStat;

                foreach (Champions champion in teamStat.previewTeam)
                {
                    if(!CreateBuildViewModel.ChampionTeam.Any(cham => cham.name == champion.name))
                        CreateBuildViewModel.TraitTeamList(champion, "add");

                    CreateBuildViewModel.ChampionTeam.Add(champion);
                }

                CurrentView = createBuildVM;
            }
        }

        public MainViewModel()
        {
            mainVM = this.mainVM;
            allChampionVM = new AllChampionsViewModel();
            allItemsVM = new AllItemsViewModel();
            createBuildVM = new CreateBuildViewModel();
            BuildVM = new BuildViewModel();
            teamInfo = new ObservableCollection<Team>(JsonData.GetTeamInfo());

            loadBuildCommand = new Commands(LoadBuild);
            deleteBuildCommand = new Commands(DeleteBuild);
            editBuildCommand = new Commands(EditBuild);

            mainViewCommnd = new Commands(obj =>
            {
                teamInfo = new ObservableCollection<Team>(JsonData.GetTeamInfo());
                CurrentView = mainVM;
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
                CreateBuildViewModel.team = new Team();
                CreateBuildViewModel.TeamTrait = new ObservableCollection<Traits>();
                CreateBuildViewModel.ChampionTeam = new ObservableCollection<Champions>();
                CreateBuildViewModel.traits = new ObservableCollection<Traits>(JsonData.GetTraits());

                CurrentView = createBuildVM;
            });
        }
    }
}
