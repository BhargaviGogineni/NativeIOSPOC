using Foundation;
using System;
using UIKit;
using XamarinNativPOC.iOS.Models.Responses;

namespace XamarinNativPOC.iOS
{
    public partial class TvCell : UITableViewCell
    {
        public TvCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(Species data)
        {
            try
            {
                view.BackgroundColor = UIColor.FromRGB(232, 234, 237);

                view.Layer.CornerRadius = 15;
                
                titleLbl.Text = data.title;
                descriptionLbl.Text = data.description;
                if (data.imageHref != null)
                {
                    try
                    {
                        if (image.Image == null)
                            image.Image = data.imageHref.FromUrl();

                    }
                    catch (Exception ex)
                    {
                        image.Image = UIImage.FromBundle("Defaultimg");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}