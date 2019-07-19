using Foundation;
using System;
using UIKit;

namespace XamarinNativPOC.iOS
{
    public partial class PractiseViewController : UIViewController
    {
        public PractiseViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ImageView.Image = UIImage.FromBundle("img");

            LoginBtn.TouchUpInside += LoginBtn_TouchUpInside;

        }

        private void LoginBtn_TouchUpInside(object sender, EventArgs e)
        {
           
            if(Username.Text.Length<=1)
            {
               
            }
        }
    }
}