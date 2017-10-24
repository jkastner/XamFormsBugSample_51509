using Autofac;
using Test_NavPage.Views;
using Xamarin.Forms;

namespace Test_NavPage.ViewModels
{
  public class SingleEntryViewModel : BindableObject
  {
    private string _descriptiveText;

    private double _descriptiveFontSize;
    private string _hasNavBar;
    private string _myPageTitle = "Single Entry Page";
    private bool _isAfterBackButton;

    public SingleEntryViewModel()
    {
      NavigateToTestPageCommand = new Command(NavigateToTestPage);
      DescriptiveText = "Once the page gets focus, the NavigationBar is hidden and the space is reclaimed";
    }

    public string DescriptiveText
    {
      get { return _descriptiveText; }
      set
      {
        _descriptiveText = value;
        OnPropertyChanged();
      }
    }

    public Command NavigateToTestPageCommand { get; set; }

    private void NavigateToTestPage()
    {
      var target = IoC.Scope.Resolve<SomeOtherPage>();
      IoC.Scope.Resolve<NavigationViewModel>().NavigateTo(target);
      DescriptiveText = "6. Notice, after returning, the NavigationBar is visible. This is the bug. You can avoid this bug by setting the Page Title to empty in the optional step 7 below.";
      DescriptiveFontSize = 30;
      IsAfterBackButton = true;
    }

    public double DescriptiveFontSize
    {
      get { return _descriptiveFontSize; }
      set
      {
        _descriptiveFontSize = value;
        this.OnPropertyChanged();
      }
    }

    public bool IsAfterBackButton
    {
      get { return _isAfterBackButton; }
      set
      {
        _isAfterBackButton = value;
        this.OnPropertyChanged();
      }
    }

    public string HasNavBar
    {
      get { return _hasNavBar; }
      set
      {
        _hasNavBar = value;
        this.OnPropertyChanged();
      }
    }

    public string MyPageTitle
    {
      get { return _myPageTitle; }
      set
      {
        _myPageTitle = value;
        this.OnPropertyChanged();
      }
    }
    
  }
}