using System.Collections.ObjectModel;
using Autofac;
using Xamarin.Forms;

namespace Test_NavPage.ViewModels
{
  class MainViewModel : BindableObject
  {
    private NavigationViewModel _navigationViewModel;


    private ContentPage _selectedPage;
    private bool _isPresented;

    private readonly ObservableCollection<ContentPage> _masterPageItems;

    public MainViewModel()
    {
      _masterPageItems = new ObservableCollection<ContentPage>();
      NavigationPoppedCommand = new Command(NavigationPopped);
      SingleEntryPage sep = IoC.Scope.Resolve<SingleEntryPage>();
      BrowseEntriesPage bep = IoC.Scope.Resolve<BrowseEntriesPage>();
      _masterPageItems.Add(sep);
      _masterPageItems.Add(bep);
    }

    public bool IsPresented
    {
      get => _isPresented;
      set
      {
        if (_isPresented != value)
        {
          _isPresented = value;
          OnPropertyChanged();
        }
      }
    }

    public Command NavigationPoppedCommand { get; set; }

    public ContentPage SelectedPage
    {
      get => _selectedPage;
      set
      {
        if (_selectedPage != value)
        {
          _selectedPage = value;
          OnPropertyChanged();
          ListViewOnItemSelected();
        }
      }
    }

    private NavigationViewModel NavigationViewModel
    {
      get
      {
        if (_navigationViewModel == null)
        {
          _navigationViewModel = IoC.Scope.Resolve<NavigationViewModel>();
        }
        return _navigationViewModel;
      }
    }

    public ObservableCollection<ContentPage> Pages => _masterPageItems;

    private void NavigationPopped()
    {
      SelectedPage = null;
    }

    private void ListViewOnItemSelected()
    {
      if (SelectedPage != null)
      {
        NavigationViewModel.NavigateToAtRoot(SelectedPage);
      }
    }
  }
}