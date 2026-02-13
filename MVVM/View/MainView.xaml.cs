using Tasker.MVVM.ViewModel;

namespace Tasker.MVVM.View;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();

	}
}