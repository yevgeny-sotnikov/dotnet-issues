using System;
using AppKit;
using macOSApp1;


static class MainClass
{
    static void Main(string[] args)
    {
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        // This is the main entry point of the application.
        NSApplication.Init();
        NSApplication.Main(args);
    
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        int i = 0;

    }
}

