using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TFT_TEAM_BUILDER.Core
{
    // Класс для сигнала о том, что состояния объекта изменилась по правилам патерна MVVM
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
