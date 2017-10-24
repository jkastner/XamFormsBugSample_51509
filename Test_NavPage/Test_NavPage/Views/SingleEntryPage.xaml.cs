using System;
using Test_NavPage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_NavPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SingleEntryPage : ContentPage
	{
		public SingleEntryPage ()
		{
			InitializeComponent ();
      BindingContext = IoC.Resolve<SingleEntryViewModel>();
    }

	  private void CheckHasNavBarCommand(object sender, EventArgs e)
	  {
	    IoC.Resolve<SingleEntryViewModel>().HasNavBar = NavigationPage.GetHasNavigationBar(this).ToString();

	  }

  }
}