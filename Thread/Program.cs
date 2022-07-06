// See https://aka.ms/new-console-template for more information
using System.Threading;

Console.WriteLine("Hello, World!");

 Timer _timer = null;
// Create a Timer object that knows to call our TimerCallback
// method once every 2000 milliseconds.
_timer = new Timer(TimerCallback, null, 0, 2000);
// Wait for the user to hit <Enter>
Console.ReadLine();
 static void TimerCallback(Object o)
{
    // Display the date/time when this method got called.
    Console.WriteLine("In TimerCallback: " + DateTime.Now);
}

while (true)
{
    Console.WriteLine("Start? Yes Or No");
    string? v = Console.ReadLine(); 
    if (v == "Yes")
    {

    }
}

Thread thread1 = new Thread(() =>
{
	
})
{
	IsBackground = true
};


