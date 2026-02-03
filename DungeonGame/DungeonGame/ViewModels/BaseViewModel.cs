using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DungeonGame.ViewModels;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
}
