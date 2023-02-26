using GongSolutions.Wpf.DragDrop;
using System.Collections.ObjectModel;
using System.Windows;
using TFT_TEAM_BUILDER.Models;

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

                if (targetCollection.Count == 0)
                {
                    targetCollection.Add(dropChampion);
                }
                else
                {
                    var collection = dropInfo.DragInfo.SourceCollection as ObservableCollection<Champions>;


                    if (collection.Count > 2)
                    {
                        return;
                    }
                    else if (targetCollection.Count > 2)
                    {
                        collection.Clear();
                    }
                    else
                    {
                        targetCollection.Clear();
                        targetCollection.Add(dropChampion);
                    }
                }
            }
        }
    }
}
