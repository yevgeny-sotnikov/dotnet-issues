using System;
using AppKit;
using Foundation;

namespace macOSApp1;

[Register("AppDelegate")]
public class AppDelegate : NSApplicationDelegate
{
    public override void DidFinishLaunching(NSNotification notification)
    {
        try
        {
            throw new MyException("I want to get this exception at least at console output, also, i need to handle this exception - app shouldn't crash");
        }
        catch (MyException e)
        {
            Console.WriteLine(e);
        }
    }

    public override void WillTerminate(NSNotification notification)
    {
        // Insert code here to tear down your application
    }
}