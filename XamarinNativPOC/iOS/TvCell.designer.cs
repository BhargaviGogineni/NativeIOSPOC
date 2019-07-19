// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinNativPOC.iOS
{
    [Register ("TvCell")]
    partial class TvCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel descriptionLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView image { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel titleLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView view { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (descriptionLbl != null) {
                descriptionLbl.Dispose ();
                descriptionLbl = null;
            }

            if (image != null) {
                image.Dispose ();
                image = null;
            }

            if (titleLbl != null) {
                titleLbl.Dispose ();
                titleLbl = null;
            }

            if (view != null) {
                view.Dispose ();
                view = null;
            }
        }
    }
}