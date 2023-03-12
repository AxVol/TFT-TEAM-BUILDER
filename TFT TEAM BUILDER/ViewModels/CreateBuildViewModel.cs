using System.Collections.ObjectModel;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.Core;
using GongSolutions.Wpf.DragDrop;
using System.Linq;
using System.Windows;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class CreateBuildViewModel : ObservableObject
    {
        // Синглтон хэндлер для драг'н'дропа
        private static IDropTarget instance;
        public static IDropTarget Instance => instance = new ChromerDragDrop();

        public Commands TraitSortCommand { get; set; } 
        public Commands SaveTeamCommand { get; set; }

        public static ObservableCollection<Champions> champions { get; set; } // Список всех чемпионов
        public static ObservableCollection<Champions> offerList { get; set; } // Список с отсортированными чемпионами отображаемые на вью которые могут подойти в команду
        public static ObservableCollection<Champions> ChampionTeam { get; set; } = new ObservableCollection<Champions>();
        public static ObservableCollection<Traits> traits { get; set; } = new ObservableCollection<Traits>(JsonData.GetTraits()); // Перки
        public static ObservableCollection<Traits> TeamTrait { get; set; } = new ObservableCollection<Traits>();
        public ObservableCollection<Champions> sortList { get; set; } // Список который отображаеться на вью и производит сортировка в поиске
        public ObservableCollection<Items> allItems { get; set; } // Предметы
        public ObservableCollection<Items> itemsView { get; set; }

        public static Team team { get; set; } = new Team();

        // Переменные для свойств
        private string searchText;
        private string saveInformationText = "Название сборки";
        private string fileName;

        public string saveFileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }
        public string SortEvent {
            get
            {
                return searchText;
            }
            set
            {
                searchText = value;

                sortList.Clear();

                foreach (Champions champion in champions)
                {
                    if (champion.name.ToLower().StartsWith(searchText.ToLower()))
                    {
                        sortList.Add(champion);
                    }
                }
            } 
        }
        // Информация, для отображение после нажатия кнопки "Сохранить"
        public string Text
        {
            get { return saveInformationText; }
            set { saveInformationText = value; }
        }
        // Метод отвечающий за сортировку по перкам, по нажати на каждый из них
        private void TraitSort(object data)
        {
            string trait = data as string;

            sortList.Clear();

            foreach (Champions champion in champions)
            {
                if (champion.traits.Any(s => s.IndexOf(trait) > -1))
                {
                    sortList.Add(champion);
                }
            }   
        }
        // Метод отвечабщий за предложение чемпионов, которые могут подойти в команду, пока что алгоритм простой, предлагает
        // всех, у кого совпадают перки, с перками команды
        public static void OfferList(Champions dropChampion)
        {
            offerList.Clear();

            foreach (Traits trait in TeamTrait)
            {
                foreach (Champions champion in champions)
                {
                    if (champion.traits.Contains(trait.name))
                    {
                        if (!ChampionTeam.Contains(champion) && !offerList.Contains(champion))
                        {
                            if (!(champion.name == dropChampion.name))
                                offerList.Add(champion);
                        }
                    }
                }
            }
        }
        // Метод отвечающий за добавление или удаление перков из команды, действие зависит от параметра "action"
        public static void TraitTeamList(Champions champion, string action)
        {
            switch (action)
            {
                case "add":
                    foreach (string traitName in champion.traits)
                    {
                        foreach (Traits trait in traits)
                        {
                            if (traitName == trait.name)
                            {
                                trait.teamCount++;

                                if (!TeamTrait.Contains(trait))
                                    TeamTrait.Add(trait);
                            }
                        }
                    }
                    break;

                case "remove":
                    foreach (string traitName in champion.traits)
                    {
                        foreach (Traits trait in traits)
                        {
                            if (traitName == trait.name)
                            { 
                                trait.teamCount--;

                                if (trait.teamCount == 0)
                                    TeamTrait.Remove(trait);
                            }
                        }
                    }
                    break;
                default:
                    throw new System.Exception("Не корректное действи, существует только - 'remove' для удаления и 'add' для добавления ");
            }         
        }
        // Метод отвечащий за выбрасывания предметов без крафта, так как их выпадение слишком редкое и решаеться по факту, 
        // нужны ли они, или нет
        public ObservableCollection<Items> ItemsView(ObservableCollection<Items> itemsList)
        {
            ObservableCollection<Items> items = new ObservableCollection<Items>();

            foreach (Items item in itemsList)
            {
                if (!(item.craft.Length == 0))
                {
                    items.Add(item);
                }
            }

            return items;
        }

        public CreateBuildViewModel()
        {
            sortList = new ObservableCollection<Champions>(JsonData.GetChampions());
            champions = new ObservableCollection<Champions>(JsonData.GetChampions());
            allItems = new ObservableCollection<Items>(JsonData.GetItems());
            offerList = new ObservableCollection<Champions>();
            itemsView = ItemsView(allItems);

            TraitSortCommand = new Commands(TraitSort);
            SaveTeamCommand = new Commands(obj => 
            {
                if (saveFileName != null)
                {
                    try
                    {
                        Text = "Сохранено";
                        team.name = saveFileName;
                        team.teamTraits = TeamTrait;
                        team.previewTeam = ChampionTeam;

                        team.Serialize();
                    }
                    catch
                    {
                        Text = "Некоректное название";
                    }
                }
                else
                {
                    Text = "Введите название";
                }
            });           
        }
    }
}
