using System.Diagnostics;

namespace TimeCollections;

public partial class RegistrationView : ContentPage
{
    Stopwatch stopwatch = new Stopwatch(); 
    private bool isRunning;

    public RegistrationView()
	{
		InitializeComponent();
	}

    private void OnStartStop(object sender, EventArgs e)
    {
        isRunning = !isRunning;
        StartStopContinueTime.Text = isRunning ? "Pause" : "Start"; 
        while (isRunning)
        {
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            stopwatch.Stop();

            SetTime();
            Debug.WriteLine(stopwatch.Elapsed);
            //Counter.Text = $"{stopwatch.Elapsed.TotalSeconds}";
        }
    }
    private void SetTime()
    {
        Counter.Text = $"{stopwatch.Elapsed.TotalSeconds}";
    }
}