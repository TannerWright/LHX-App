using System;

using UIKit;

namespace LHXApp.iOS.Controller
{
    public partial class HomeController : UIViewController
    {
        public HomeController(IntPtr p) : base(p)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ScrollBar.ContentSize = Content.Bounds.Size;
        }
    }
}