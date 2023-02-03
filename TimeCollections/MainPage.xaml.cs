using System.Data;
using System.Diagnostics;
using System.Timers;
using System.Threading;




namespace TimeCollections;

public partial class MainPage : ContentPage
{
	private IDispatcherTimer timer;

	private int counterInSeconds;

	private bool isRunning;




	public MainPage()
	{
		InitializeComponent();

		timer = Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += Timer_Tick;


		Button startButton = new Button { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Start" };
		startButton.Clicked += StartButton_Clicked;
		Button stopButton = new Button { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center, Text = "Stop" };
		stopButton.Clicked += StopButton_Clicked;

		Content = new StackLayout
		{
			Children =
			{
				counterLabel,
				startButton,
				stopButton
			}
		};
	}

	private void Timer_Tick(object sender, EventArgs e)
	{
		counterInSeconds++;
		int minutes = counterInSeconds / 60;
		int seconds = counterInSeconds % 60;
		int hours = minutes / 60;
		minutes = minutes % 60;

		counterLabel.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
	}

	public void StartButton_Clicked(object sender, EventArgs e)
	{
		

		timer.Start();
	
		isRunning = true;

	}
	
	public void StopButton_Clicked(object sender, EventArgs e)
	{
		

		timer.Stop();
	
		isRunning = false;

	}

	

}

