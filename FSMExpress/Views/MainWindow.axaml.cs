using Avalonia.Controls;
using Avalonia.Interactivity;
using FSMExpress.ViewModels;

namespace FSMExpress.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel vm)
        {
            vm.Loaded();
        }
    }
}