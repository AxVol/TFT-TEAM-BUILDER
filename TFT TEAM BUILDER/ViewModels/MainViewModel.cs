using TFT_TEAM_BUILDER.Core;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public Commands allItemCommand { get; set; }
        public Commands allChampionsCommand { get; set; }
        public Commands myBuildsCommand { get; set; }
        public Commands createBuildCommand { get; set; }

        public AllChampionsViewModel allChampionVM { get; set; }
        public AllItemsViewModel allItemsVM { get; set; }
        public MyBuildsViewModel myBuildsVM { get; set; }
        public CreateBuildViewModel createBuildVM { get; set; }

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
            myBuildsVM = new MyBuildsViewModel();
            createBuildVM = new CreateBuildViewModel();

            CurrentView = myBuildsVM;

            allChampionsCommand = new Commands(obj =>
            {
                CurrentView = allChampionVM;
            });

            allItemCommand = new Commands(obj =>
            {
                CurrentView = allItemsVM;
            });

            myBuildsCommand = new Commands(obj =>
            {
                CurrentView = myBuildsVM;
            });

            createBuildCommand = new Commands(obj =>
            {
                CurrentView = createBuildVM;
            });
        }
    }
}
