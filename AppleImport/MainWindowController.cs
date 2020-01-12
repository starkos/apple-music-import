using System;

using AppKit;
using CoreGraphics;
using Foundation;
using WebKit;

namespace AppleImport
{
	public partial class MainWindowController : NSWindowController
	{
		private readonly WKWebView _webView;


		public MainWindowController()
		{
			WindowFrameAutosaveName = "MainWindow";

			var contentRect = new CGRect(100, 100, 800, 600);

			_webView = new WKWebView(contentRect, new WKWebViewConfiguration());

			var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
			base.Window = new NSWindow(contentRect, style, NSBackingStore.Buffered, true)
			{
				Title = "Apple Import",
				ContentView = _webView
			};
		}


		public void LoadUri(Uri uri)
		{
			var request = new NSUrlRequest(uri);
			_webView.LoadRequest(request);
		}
	}
}

