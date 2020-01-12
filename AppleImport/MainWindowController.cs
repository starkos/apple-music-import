using System;

using AppKit;
using CoreGraphics;

namespace AppleImport
{
	public partial class MainWindowController : NSWindowController
	{
		public MainWindowController()
		{
			WindowFrameAutosaveName = "MainWindow";

			var contentRect = new CGRect(100, 100, 800, 600);
			var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
			base.Window = new NSWindow(contentRect, style, NSBackingStore.Buffered, true)
			{
				Title = "Apple Import"
			};
		}

		public new MainWindow Window
		{
			get { return (MainWindow)base.Window; }
		}
	}
}

