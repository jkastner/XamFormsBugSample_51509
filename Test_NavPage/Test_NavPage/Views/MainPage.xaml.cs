using Autofac;
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
      IoC.Scope.Resolve<NavigationViewModel>().InitializeFrom(this.MainNavigationPage);
      _viewModel = IoC.Scope.Resolve<MainViewModel>();
      BindingContext = IoC.Scope.Resolve<MainViewModel>();
      var firstPage = IoC.Scope.Resolve<BrowseEntriesPage>();
      IoC.Scope.Resolve<NavigationViewModel>().NavigateToAtRoot(firstPage);
    }

    public void OnPopped(object sender, NavigationEventArgs e)
    {
      _viewModel.NavigationPoppedCommand?.Execute(sender);
    }
  }
} 