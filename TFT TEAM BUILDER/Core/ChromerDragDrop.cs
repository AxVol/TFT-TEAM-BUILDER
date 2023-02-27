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
            if (dropInfo.TargetCollection is ObservableCollection<Champions> targetCollection)
            {
                Champions dropChampion = dropInfo.Data as Champions;
                var collection = dropInfo.DragInfo.SourceCollection as ObservableCollection<Champions>;

                if (collection.Count > 2 && targetCollection.Count > 2)
                { 
                    return;
                }
                else if (targetCollection.Count > 2)
                {
                    collection.Clear();
                    CreateBuildViewModel.OfferList(dropChampion);
                }
                else if (collection.Count == 1 && targetCollection.Count == 0) 
                {
                    collection.Clear();
                    targetCollection.Add(dropChampion);
                }
                else if (targetCollection.Count == 1 && collection.Count == 1) 
                {
                    Champions tempChampion = targetCollection[0];

                    targetCollection.Clear();
                    collection.Clear();

                    targetCollection.Add(dropChampion);
                    collection.Add(tempChampion);

                }
                else if (targetCollection.Count == 1)
                {
                    targetCollection.Clear();
                    targetCollection.Add(dropChampion);
                    CreateBuildViewModel.OfferList(dropChampion);
                }
                else
                {
                    targetCollection.Add(dropChampion);
                    CreateBuildViewModel.OfferList(dropChampion);
                }
            }
        }
    }
}
