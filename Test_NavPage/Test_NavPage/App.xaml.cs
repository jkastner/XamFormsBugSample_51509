using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Test_NavPage.ViewModels;
using Test_NavPage.Views;
using Xamarin.Forms;

namespace Test_NavPage
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
      ContainerBuilder cb = new ContainerBuilder();


      cb.RegisterType<BrowseEntriesViewModel>().As<BrowseEntriesViewModel>().SingleInstance();
      cb.RegisterType<BrowseEntriesPage>().As<BrowseEntriesPage>().SingleInstance();
      cb.RegisterType<NavigationViewModel>().AsSelf().SingleInstance();
      cb.RegisterType<SingleEntryPage>().AsSelf().SingleInstance();
      cb.RegisterType<SingleEntryViewModel>().AsSelf().SingleInstance();
      cb.RegisterType<MainViewModel>().AsSelf().SingleInstance();
      cb.RegisterType<SomeOtherPage>().AsSelf().SingleInstance();



      IoC.Scope = cb.Build().BeginLifetimeScope();
      MainPage = new MainPage();
    }




    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }


  }
}
