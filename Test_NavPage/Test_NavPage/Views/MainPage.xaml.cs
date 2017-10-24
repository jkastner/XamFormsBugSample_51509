using Test_NavPage;
using Test_NavPage.ViewModels;
using Xamarin.Forms;

namespace Test_NavPage
{
  public partial class MainPage
  {
    private MainViewModel _viewModel;

    public MainPage()
    {
      InitializeComponent();
      IoC.Resolve<NavigationViewModel>().InitializeFrom(this.MainNavigationPage);
      _viewModel = IoC.Resolve<MainViewModel>();
      BindingContext = IoC.Resolve<MainViewModel>();
      var firstPage = IoC.Resolve<BrowseEntriesPage>();
      IoC.Resolve<NavigationViewModel>().NavigateToAtRoot(firstPage);
    }

    public void OnPopped(object sender, NavigationEventArgs e)
    {
      _viewModel.NavigationPoppedCommand?.Execute(sender);
    }
  }
} 