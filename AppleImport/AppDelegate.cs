using System;

using AppKit;
using Foundation;

namespace AppleImport
{
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		MainWindowController _mainWindowController;


		public AppDelegate()
		{
			Console.WriteLine("[AppDelegate.ctor]");
		}


		public override void DidFinishLaunching(NSNotification notification)
		{
			Console.WriteLine("[AppDelegate.DidFinishLaunching]");
			_mainWindowController = new MainWindowController();
			_mainWindowController.ShowWindow(this);
		}


		public override void WillTerminate(NSNotification notification)
		{
		}
	}
}
