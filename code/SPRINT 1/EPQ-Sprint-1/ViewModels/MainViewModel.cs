using CommunityToolkit.Mvvm.ComponentModel;

namespace EPQ_Sprint_1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Greeting { get; set; } = "Welcome to Avalonia!";
}
