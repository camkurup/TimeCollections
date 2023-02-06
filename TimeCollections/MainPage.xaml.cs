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
	TimeRegistrationController timeRegistrationController = new TimeRegistrationController();

	public MainPage()
	{
		InitializeComponent();

		timeRegistrations = timeRegistrationController.GetTimeRegistrations();


		listTimeRegistrations.ItemsSource = timeRegistrations;
	}

	public void SelectedTimeRegistration(object sender, EventArgs e)
	{

	}

}

