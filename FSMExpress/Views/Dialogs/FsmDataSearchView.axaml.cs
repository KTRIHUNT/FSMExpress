using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using FSMExpress.ViewModels.Dialogs;

namespace FSMExpress.Views.Dialogs;
public partial class FsmDataSearchView : UserControl
{
    public FsmDataSearchView()
    {
        InitializeComponent();
        Loaded += FsmDataSearchView_Loaded;
    }

    private void FsmDataSearchView_Loaded(object? sender, RoutedEventArgs e)
    {
        //searchTextBox.Focus();
    }

    private void MainGrid_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            e.Handled = true;
            if (DataContext is FsmSelectorViewModel vm)
            {
                vm.PickSelectedEntries();
            }
        }
        else if (e.Key == Key.Escape)
        {
            e.Handled = true;
            if (DataContext is FsmSelectorViewModel vm)
            {
                vm.PickCancel();
            }
        }
    }

    public void ListBoxItem_DoubleTapped(object? sender, TappedEventArgs e)
    {
        if (DataContext is FsmSelectorViewModel vm)
        {
            vm.PickSelectedEntries();
        }
    }
}
