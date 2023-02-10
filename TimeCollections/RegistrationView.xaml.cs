using System.Diagnostics;

namespace TimeCollections;

//This class takes care of the registration View
//meaning that it represents the counter start/stop
public partial class RegistrationView : ContentPage
{
	private IDispatcherTimer timer;

	private int counterInSeconds;

	private bool isRunning;

	public RegistrationView()
	{
		InitializeComponent();

		timer = Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += Timer_Tick;	
	}

	//timer presentation
	private void Timer_Tick(object sender, EventArgs e)
	{
		counterInSeconds++;
		int minutes = counterInSeconds / 60;
		int seconds = counterInSeconds % 60;
		int hours = minutes / 60;
		minutes = minutes % 60;

		Counter.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
	}

	//When button is clicked the StartStop methode will be trigerd
	public void OnStartStop(object sender, EventArgs e)
	{
		StartStop();
	}

	//if the counter is running, then stop the time, else start the time - both by using propper methode from farther below
	public void StartStop()
	{
		if (isRunning)
		{
			StopTimer();

		} else
		{
			StartTimer();
		}
	}

	//starts the timer and changes the text on the button
	public void StartTimer()
	{
		timer.Start();
		StartStopContinueTime.Text = "Pause";
		isRunning = true;
	}

	//stops the timer and changes the buttons text
	public void StopTimer()
	{
		timer.Stop();
		StartStopContinueTime.Text = "Start";
		isRunning = false;
	}
}