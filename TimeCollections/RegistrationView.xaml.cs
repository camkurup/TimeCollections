using System.Diagnostics;

namespace TimeCollections;

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

	private void Timer_Tick(object sender, EventArgs e)
	{
		counterInSeconds++;
		int minutes = counterInSeconds / 60;
		int seconds = counterInSeconds % 60;
		int hours = minutes / 60;
		minutes = minutes % 60;

		Counter.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
	}

	public void OnStartStop(object sender, EventArgs e)
	{
		StartStop();
	}

	public void StartStop()
	{
		if (isRunning)
		{
			StopTimer();
		} 
		else
		{
			StartTimer();
		}
	}
	public void StartTimer()
	{
		timer.Start();
		StartStopContinueTime.Text = "Pause";
		isRunning = true;
	}

	public void StopTimer()
	{
		timer.Stop();
		StartStopContinueTime.Text = "Start";
		isRunning = false;
	}

    private void OnReturnCliked(object sender, EventArgs e)
    {

    }
}