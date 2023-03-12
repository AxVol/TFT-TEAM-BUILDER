using GongSolutions.Wpf.DragDrop;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using TFT_TEAM_BUILDER.Models;
using TFT_TEAM_BUILDER.ViewModels;

namespace TFT_TEAM_BUILDER.Core
{
    // Логика Drag'n'Drop
    // Суть которой что чемпионы должны перемещаться только в свои слоты, как и предметы. *В будущем у персонажей должен будет
    // появиться свой инвентарь*
    public class ChromerDragDrop : IDropTarget
    {
        private readonly int maxSizeSlot = 1, minimumSizeDeleteCollection = 2, baseSizeSlot = 0;

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
            if (CreateBuildViewModel.ChampionTeam.Count == 10) // Превышение лимита команды
            {
                return;
            }
            // Логика если перемещают чемпионов
            if (dropInfo.TargetCollection is ObservableCollection<Champions> targetCollection 
                && dropInfo.DragInfo.SourceCollection is ObservableCollection<Champions> collection)
            {
                Champions dropChampion = dropInfo.Data as Champions;

                if (collection == targetCollection) // Помещение главной колекции в саму себя
                { 
                    return;
                }
                else if (targetCollection.Count > minimumSizeDeleteCollection) // Удаление чемпиона из команды
                {
                    collection.Clear();

                    CreateBuildViewModel.ChampionTeam.Remove(dropChampion);

                    // так как перки персонажей при повторном добавлении не должны повторяться, то сделана провекра, проверяющая наличие
                    // персонажа в команде, после чего удаляет, либо добавляет перк, в ином случае просто забивает
                    if (!CreateBuildViewModel.ChampionTeam.Any(cham => cham.name == dropChampion.name))
                        CreateBuildViewModel.TraitTeamList(dropChampion, "remove");

                    CreateBuildViewModel.OfferList(dropChampion);
                }
                else if (collection.Count == maxSizeSlot && targetCollection.Count == baseSizeSlot)  // перемещение чемпиона внутри поля
                {
                    collection.Clear();
                    targetCollection.Add(dropChampion);
                }
                else if (targetCollection.Count == maxSizeSlot && collection.Count == maxSizeSlot) // замена местами внутри поля
                {
                    Champions tempChampion = targetCollection[0];

                    targetCollection.Clear();
                    collection.Clear();

                    targetCollection.Add(dropChampion);
                    collection.Add(tempChampion);

                }
                else if (targetCollection.Count == maxSizeSlot) // замена чемпиона, чемпионом из общего списка
                {
                    CreateBuildViewModel.TraitTeamList(targetCollection[0], "remove");
                    CreateBuildViewModel.ChampionTeam.Remove(targetCollection[0]);

                    targetCollection.Clear();
                    targetCollection.Add(dropChampion);

                    if (!CreateBuildViewModel.ChampionTeam.Any(cham => cham.name == dropChampion.name))
                        CreateBuildViewModel.TraitTeamList(dropChampion, "add");

                    CreateBuildViewModel.ChampionTeam.Add(dropChampion);
                    CreateBuildViewModel.OfferList(dropChampion);
                }
                else // это должно срабатывать когда чемпиона перемещают в пустой слот поля
                {
                    targetCollection.Add(dropChampion);

                    if (!CreateBuildViewModel.ChampionTeam.Any(cham => cham.name == dropChampion.name))
                        CreateBuildViewModel.TraitTeamList(dropChampion, "add");
                       
                    CreateBuildViewModel.ChampionTeam.Add(dropChampion);
                    CreateBuildViewModel.OfferList(dropChampion);
                }
            }
            // Логика для перемещение предметов
            else if (dropInfo.TargetCollection is ObservableCollection<Items> targetCollections
                && dropInfo.DragInfo.SourceCollection is ObservableCollection<Items> takeCollection)
            {
                if (targetCollections == takeCollection) // Предмет помещают в тот же список из которого берут
                {
                    return;
                }
                else // пермещение предмета в список нужных для команды предметов
                {
                    Items item = dropInfo.Data as Items;

                    if (!targetCollections.Any(cham => cham.name == item.name))
                        targetCollections.Add(item);

                    takeCollection.Remove(item);
                }
            }
        }
    }
}
