using System.Collections.ObjectModel;
using System.Linq;
using Autofac;
using Test_NavPage.ViewModels;

namespace Test_NavPage
{
  public class BrowseEntriesViewModel
  {
    public BrowseEntriesViewModel()
    {
      SingleEntryViewModel = IoC.Scope.Resolve<SingleEntryViewModel>();
    }

    public SingleEntryViewModel SingleEntryViewModel { get; set; }

  }
}