// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace PaintCodeConverter
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton convertButton { get; set; }

		[Outlet]
		AppKit.NSTextView convertTextView { get; set; }

		[Outlet]
		AppKit.NSTextView mainTextView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (convertButton != null) {
				convertButton.Dispose ();
				convertButton = null;
			}

			if (mainTextView != null) {
				mainTextView.Dispose ();
				mainTextView = null;
			}

			if (convertTextView != null) {
				convertTextView.Dispose ();
				convertTextView = null;
			}
		}
	}
}
