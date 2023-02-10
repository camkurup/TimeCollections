namespace TimeCollections;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("registrationview", typeof(RegistrationView));
	}
}
