// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LHXApp.iOS.Controller
{
	[Register ("HomeController")]
	partial class HomeController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView Content { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView ScrollBar { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Content != null) {
				Content.Dispose ();
				Content = null;
			}
			if (ScrollBar != null) {
				ScrollBar.Dispose ();
				ScrollBar = null;
			}
		}
	}
}
