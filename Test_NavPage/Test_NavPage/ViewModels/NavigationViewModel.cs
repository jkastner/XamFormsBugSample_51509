using Test_NavPage.ViewModels;
using Xamarin.Forms;

namespace Test_NavPage
{
  public class NavigationViewModel : BindableObject
  {
    NavigationPage _navigationPage;

    public NavigationViewModel()
    {
      MainViewModel = IoC.Resolve<MainViewModel>();
    }

    internal MainViewModel MainViewModel { get; }

    public async void NavigateToAtRoot(Page target)
    {
      await _navigationPage.PopToRootAsync();
      if (_navigationPage.CurrentPage != target)
      {
        await _navigationPage.PushAsync(target);
      }
    }

    public async void NavigateTo(Page target)
    {
      if (_navigationPage.CurrentPage != target)
      {
        await _navigationPage.PushAsync(target);
      }
    }

    public void InitializeFrom(NavigationPage theNavPage)
    {
      _navigationPage = theNavPage;
    }
  }
}