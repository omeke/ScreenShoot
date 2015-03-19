using System;
using Gtk;
using System.Timers;
using ScreenShotTest4;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
	
	protected void OnButtonStartClicked (object sender, System.EventArgs e)
	{
		initTimer();
	}
	
	public void initTimer() {
		Console.WriteLine("start: ");
		Timer myTimer = new Timer();
		myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
		myTimer.Interval = 1000; // 1000 ms is one second
		myTimer.Start();
	}
			
	public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
	{
		ScreenShot.makeScreen();
		//labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text.ToString()) + 1);
	}

}

