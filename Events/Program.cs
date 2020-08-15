using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        EventListener listener = new EventListener();
        TestEvent TestEvent = new TestEvent();
        TestEvent.handler += listener.EventOccurred;

        TestEvent.sendMessage("Hello");

        Console.ReadLine();

    }
}

public class TestArgs : EventArgs
{
    public string message { get; set; }
    public TestArgs(string arg)
    {
        message = arg;
    }
}

public class EventListener
{
     public void EventOccurred(object sender, TestArgs e)
    {
        Console.WriteLine("Event says : " + e.message);
    }

}


public class TestEvent
{
    public event EventHandler<TestArgs> handler;

    public void sendMessage(string msg)
    {
        if (handler != null)
        {
            handler(this, new TestArgs(msg));
        }
    }
}



