using System;

using AppKit;
using Foundation;

namespace AppleImport
{
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		MainWindowController _mainWindowController;


		public override void DidFinishLaunching(NSNotification notification)
		{
			_mainWindowController = new MainWindowController();

			var uri = NSBundle.MainBundle.GetUrlForResource("index", "html");
			_mainWindowController.LoadUri(uri);

			_mainWindowController.ShowWindow(this);
		}
	}
}
