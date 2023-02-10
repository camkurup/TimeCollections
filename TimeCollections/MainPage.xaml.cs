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
		Debug.WriteLine("****************");

		selectedTimeRegistration = (TimeRegistration)listTimeRegistrations.SelectedItem as TimeRegistration;
		
	//	Debug.WriteLine(selectedTimeRegistration.Project);

		

		if (selectedTimeRegistration == null)
		{
			return;
		}

		var navigationParameter = new Dictionary<string, object>
		{
			{"TimeRegistration", selectedTimeRegistration}
		};

	//	Debug.WriteLine($"{navigationParameter.Values} hej ");
		await Shell.Current.GoToAsync("registrationview", navigationParameter);



	}


}

