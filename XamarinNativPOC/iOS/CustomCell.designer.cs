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
    [Register ("CustomCell")]
    partial class CustomCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        XamarinNativPOC.iOS.CardView cardview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel descriptionlbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView img { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TItleLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cardview != null) {
                cardview.Dispose ();
                cardview = null;
            }

            if (descriptionlbl != null) {
                descriptionlbl.Dispose ();
                descriptionlbl = null;
            }

            if (img != null) {
                img.Dispose ();
                img = null;
            }

            if (TItleLabel != null) {
                TItleLabel.Dispose ();
                TItleLabel = null;
            }
        }
    }
}