using Foundation;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using UIKit;
using XamarinNativPOC.iOS.Models.Responses;

namespace XamarinNativPOC.iOS
{
    public partial class CustomCell : UITableViewCell
    {
        public CustomCell (IntPtr handle) : base (handle)
        {
        }

        public  void UpdateCell(Species data)
        {
            try
            {
                TItleLabel.Text = data.title;
                descriptionlbl.Text = data.description;
                if (data.imageHref != null)
                {
                    try
                    {
                        if (img.Image == null)
                            img.Image = data.imageHref.FromUrl();
                       
                    }
                    catch (Exception ex)
                    {
                        img.Image = UIImage.FromBundle("Defaultimg");
                    }
                }
            }
            catch (Exception ex)
            {

            }
           
        }

    }


   public static class Demo
    {
        public static UIImage FromUrl(this string uri)
        {
            try
            {
                using (var url = new NSUrl(uri))
                using (var data = NSData.FromUrl(url))
                    return UIImage.LoadFromData(data);
            }
            catch (Exception ex)
            {
                return UIImage.FromBundle("Defaultimg");
            }            
        }
    }
}
