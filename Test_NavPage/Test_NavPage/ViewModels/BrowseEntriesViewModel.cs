using System.Collections.ObjectModel;
using System.Linq;
using Test_NavPage.ViewModels;

namespace Test_NavPage
{
  public class BrowseEntriesViewModel
  {
    public BrowseEntriesViewModel()
    {
      SingleEntryViewModel = IoC.Resolve<SingleEntryViewModel>();
    }

    public SingleEntryViewModel SingleEntryViewModel { get; set; }

  }
}