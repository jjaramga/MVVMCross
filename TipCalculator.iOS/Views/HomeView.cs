using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using TipCalculator.Core.ViewModels;

namespace TipCalculator.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeView : MvxViewController
    {
        public HomeView() : base("HomeView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //Binding with viewmodel
            var set = this.CreateBindingSet<HomeView, TipViewModel>();
            set.Bind(TextField).To(vm => vm.SubTotal);
            //set.Bind(Button).To(vm => vm.ResetTextCommand);
            set.Apply();
        }
    }
}
