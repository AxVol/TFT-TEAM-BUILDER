using System.Collections.ObjectModel;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.Core;
using GongSolutions.Wpf.DragDrop;
using System.Linq;
using System;
using Newtonsoft.Json.Serialization;
using System.IO;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class CreateBuildViewModel : ObservableObject
    {
        private static IDropTarget instance;
        public static IDropTarget Instance => instance = new ChromerDragDrop();

        private string text;

        public Commands TraitSortCommand { get; set; } 

        public static ObservableCollection<Champions> champions { get; set; }
        public static ObservableCollection<Champions> sortList { get; set; }
        public static ObservableCollection<Traits> traits { get; set; }
        public static ObservableCollection<Champions> offerList { get; set; }
        public static ObservableCollection<Traits> TeamTrait { get;set; }

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

        public static void OfferList()
        {
            
        }

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
            }         
        }

        public CreateBuildViewModel()
        {
            sortList = new ObservableCollection<Champions>(JsonData.GetChampions());
            champions = new ObservableCollection<Champions>(JsonData.GetChampions());
            traits = new ObservableCollection<Traits>(JsonData.GetTraits());
            offerList = new ObservableCollection<Champions>();
            TeamTrait = new ObservableCollection<Traits>();

            TraitSortCommand = new Commands(TraitSort);

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
    }
}
