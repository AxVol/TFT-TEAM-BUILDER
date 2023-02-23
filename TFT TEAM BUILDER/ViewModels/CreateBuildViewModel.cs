using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.Core;
using TFT_TEAM_BUILDER.Views;

namespace TFT_TEAM_BUILDER.ViewModels
{
    class CreateBuildViewModel : ObservableObject
    {
        private string text;

        public ObservableCollection<Champions> champions { get; set; }
        public ObservableCollection<Champions> sortList { get; set; }

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
                    if (champion.name.Contains(text))
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
        }
    }
}
