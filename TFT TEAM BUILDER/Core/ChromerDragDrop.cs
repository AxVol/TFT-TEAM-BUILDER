using GongSolutions.Wpf.DragDrop;
using System.Collections.ObjectModel;
using System.Windows;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.ViewModels;

namespace TFT_TEAM_BUILDER.Core
{
    public class ChromerDragDrop : IDropTarget
    {
        public void DragEnter(IDropInfo dropInfo)
        {
            
        }

        public void DragLeave(IDropInfo dropInfo)
        {

        }

        public void DragOver(IDropInfo dropInfo)
        {
            dropInfo.Effects = DragDropEffects.Copy;
        }

        public void Drop(IDropInfo dropInfo)
        {
            if (dropInfo.TargetCollection is ObservableCollection<Champions> targetCollection 
                && dropInfo.DragInfo.SourceCollection is ObservableCollection<Champions> collection)
            {
                Champions dropChampion = dropInfo.Data as Champions;

                if (collection.Count > 2 && targetCollection.Count > 2) // Помещение главной колекции в саму себя
                { 
                    return;
                }
                else if (targetCollection.Count > 2) // Удаление чемпиона из команды
                {
                    collection.Clear();
                    CreateBuildViewModel.ChampionTeam.Remove(dropChampion);
                    CreateBuildViewModel.TraitTeamList(dropChampion, "remove");
                    //CreateBuildViewModel.OfferList();
                }
                else if (collection.Count == 1 && targetCollection.Count == 0) 
                {
                    collection.Clear();
                    targetCollection.Add(dropChampion);
                }
                else if (targetCollection.Count == 1 && collection.Count == 1) // замена местами внутри команды
                {
                    Champions tempChampion = targetCollection[0];

                    targetCollection.Clear();
                    collection.Clear();

                    targetCollection.Add(dropChampion);
                    collection.Add(tempChampion);

                }
                else if (targetCollection.Count == 1) // замена чемпиона, чемпионом из общего списка
                {
                    CreateBuildViewModel.TraitTeamList(targetCollection[0], "remove");
                    CreateBuildViewModel.ChampionTeam.Remove(targetCollection[0]);
                    CreateBuildViewModel.ChampionTeam.Add(dropChampion);
                    targetCollection.Clear();
                    targetCollection.Add(dropChampion);

                    if (!CreateBuildViewModel.ChampionTeam.Contains(dropChampion))
                        CreateBuildViewModel.TraitTeamList(dropChampion, "add");

                    //CreateBuildViewModel.OfferList();
                }
                else
                {
                    targetCollection.Add(dropChampion);
                    CreateBuildViewModel.ChampionTeam.Add(dropChampion);

                    if (!CreateBuildViewModel.ChampionTeam.Contains(dropChampion))
                        CreateBuildViewModel.TraitTeamList(dropChampion, "add");

                    //CreateBuildViewModel.OfferList();
                }
            }
            else if (dropInfo.TargetCollection is ObservableCollection<Items> targetCollections
                && dropInfo.DragInfo.SourceCollection is ObservableCollection<Items> takeCollection)
            {
                Items item = dropInfo.Data as Items;

                targetCollections.Add(item);
                takeCollection.Remove(item);
            }
        }
    }
}
