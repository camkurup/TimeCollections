using System.Data;
using System.Diagnostics;
using System.Timers;
using System.Threading;
using TimeCollections.Model;
using TimeCollections.Controller;
namespace TimeCollections;


public partial class MainPage : ContentPage
{
	private List<TimeRegistration> timeRegistrations;
	TimeRegistration selectedTimeRegistration = new TimeRegistration();
	TimeRegistrationController timeRegistrationController = new TimeRegistrationController();



	public MainPage()
	{
		InitializeComponent();



		timeRegistrations = timeRegistrationController.GetTimeRegistrations();


		listTimeRegistrations.ItemsSource = timeRegistrations;

	}
	

	private async void SelectedItem(object sender, SelectionChangedEventArgs e)
	{
	
		selectedTimeRegistration = (TimeRegistration)listTimeRegistrations.SelectedItem;
		
		Debug.WriteLine($"{selectedTimeRegistration.Project} - projektet i gemt i selected item");

		if (selectedTimeRegistration == null)
		{
			return;
		}

		var navigationParameter = new Dictionary<string, object>
		{
			{"Registration", selectedTimeRegistration}
		};

		Debug.WriteLine($"{navigationParameter} - navigationsparameter ");
		await Shell.Current.GoToAsync("registrationview", navigationParameter);
	}
}

