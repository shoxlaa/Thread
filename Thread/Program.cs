using System.Threading;



//while (true)
//{
//    Console.WriteLine("Start? Yes Or No");
//    string? v = Console.ReadLine(); 
//    if (v == "Yes")
//    {

//    }
//}
DateTime Begin = DateTime.Now;
DateTime End = DateTime.Now;
int iteration = 0;
double Difference = 0;

Thread CountTime = new Thread(() =>
{
    End = DateTime.Now;

    Difference = (End - Begin).TotalMilliseconds;
})
{
    IsBackground = true
};

Thread SpanValue = new Thread(() =>
{
    Console.WriteLine("Press Space");
    Console.ReadKey();
    Begin = DateTime.Now;
})
{
    IsBackground = true
};

SpanValue.Start();
CountTime.Start();
SpanValue.Join();
CountTime.Join();
Console.WriteLine(Difference);




//public class MyTimer
//{
//public DateTime Begin { get; set; } 
//public DateTime End { get; set; }
//public System.Timers.Timer Timer { get; set; }  
//public int Interval { get; set; }	= 500;
//public int Difference { get; private set; }

//	public MyTimer()
//    {
//		Timer = new System.Timers.Timer(); 

//	} 
//	public void Start()
//    {
//		Timer.Interval = Interval;
//		Timer.Elapsed += OnTimedEvent;
//		Timer.AutoReset = true;
//		Timer.Enabled = true;
//		Console.WriteLine("Press the Enter key to exit anytime... ");
//		Console.ReadLine();

//		// Releasing Timer resources once done
//		Timer.Stop();
//		Timer.Dispose(); 

//		Console.WriteLine(Difference);

//	}
//	private int iteration = 0;
//	 void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
//	{
//		// Code to be executed at the end of Timer
//		if (iteration == 0)
//		{
//			Begin = DateTime.Now; 
//			iteration++;
//		} 
//		End = DateTime.Now; 

//		Difference =  (End.Second-Begin.Second);

//	}
//}


//MyTimer timer = new();

//timer.Start();
