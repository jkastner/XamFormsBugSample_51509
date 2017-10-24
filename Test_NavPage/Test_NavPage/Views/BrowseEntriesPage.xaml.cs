using Autofac;
using Test_NavPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_NavPage
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class BrowseEntriesPage : ContentPage
  {
    public BrowseEntriesPage()
    {
      InitializeComponent();
      BindingContext = IoC.Scope.Resolve<BrowseEntriesViewModel>();
    }
    
	}
}