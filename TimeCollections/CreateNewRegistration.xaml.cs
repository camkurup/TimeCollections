using TimeCollections.Model;

namespace TimeCollections;

public partial class CreateNewRegistration : ContentPage
{

	List<TimeRegistration> registrations = new List<TimeRegistration> {
		new TimeRegistration("project1", "Hans Hansen ApS", "JSH", "Programmering", "PIM Project"),
		new TimeRegistration("project2", "Malermester Søren & Søn AS", "JSH", "Konsulenttimer", "Kontogrupper"),
		new TimeRegistration("project3", "Elektrikeren ApS", "JSH", "Konsulenttimer", "Business Robot"),
		new TimeRegistration("project4", "VVSkovs ApS", "JSH", "Konsulenttimer", "Finansbudget"),
		new TimeRegistration("project5", "Marius M AS", "JSH", "Programmering", "Open Economy"),
		new TimeRegistration("project6", "LEMASH ApS", "JSH", "Programmering", "API"),
		new TimeRegistration("project7", "Lolland-Falsters Bryghus AS", "JSH", "Konsulenttimer", "PowerBI")
	};
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

	private void AddNewRegistrations()
	{
		List<TimeRegistration> newTimeRegistrations = new List<TimeRegistration> {
		new TimeRegistration("project1", "Hans Hansen ApS", "JSH", "Programmering", "PIM Project"),
		new TimeRegistration("project2", "Malermester Søren & Søn AS", "JSH", "Konsulenttimer", "Kontogrupper"),
		new TimeRegistration("project3", "Elektrikeren ApS", "JSH", "Konsulenttimer", "Business Robot"),
		new TimeRegistration("project4", "VVSkovs ApS", "JSH", "Konsulenttimer", "Finansbudget"),
		new TimeRegistration("project5", "Marius M AS", "JSH", "Programmering", "Open Economy"),
		new TimeRegistration("project6", "LEMASH ApS", "JSH", "Programmering", "API"),
		new TimeRegistration("project7", "Lolland-Falsters Bryghus AS", "JSH", "Konsulenttimer", "PowerBI")
	};

		registrations.AddRange(newTimeRegistrations);
	}


	


}