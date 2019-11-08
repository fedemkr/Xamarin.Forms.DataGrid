
using Xamarin.Forms;

namespace DataGridSample
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            if (Device.RuntimePlatform == Device.macOS)
                dgMain.HeaderMargin = new Thickness(2, 0, 17, 0);

        }
	}
}
