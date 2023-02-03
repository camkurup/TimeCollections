using TimeCollections.Model;

namespace TimeCollections;

public partial class CreateNewRegistration : ContentPage
{

	List<TimeRegistration> registrations;
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

		registrations.Add(timeRegistration);
	}
}