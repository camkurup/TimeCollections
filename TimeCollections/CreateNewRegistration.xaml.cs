using TimeCollections.Controller;
using TimeCollections.Model;

namespace TimeCollections;

public partial class CreateNewRegistration : ContentPage
{
	private TimeRegistrationController controller;
	public CreateNewRegistration()
	{
		InitializeComponent();
	}

	private void OnCreateRegistration(object sender, EventArgs e)
	{
		TimeRegistration timeRegistration = new TimeRegistration(
			InputProjectName.ToString(), 
			InputCustomer.ToString(), 
			InputEmployee.ToString(), 
			InputActivity.ToString(), 
			InputText.ToString());

		controller.GetTimeRegistrations().Add(timeRegistration);
		
	}

	


	


}