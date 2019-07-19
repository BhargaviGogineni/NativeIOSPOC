using Foundation;
using System;
using UIKit;
using XamarinNativPOC.iOS.Models.Responses;

namespace XamarinNativPOC.iOS
{
    public partial class CustomCollectionViewCell : UICollectionViewCell
    {
        public CustomCollectionViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(Species data)
        {
            try
            {
                ContentView.BackgroundColor = UIColor.FromRGB(232, 234, 237);
                ContentView.Layer.CornerRadius = 15;

                TitleLAbel.Text = data.title;
                DescriptionLabl.Text = data.description;
                if (data.imageHref != null)
                {
                    try
                    {
                        if (ImageV.Image == null)
                            ImageV.Image = data.imageHref.FromUrl();

                    }
                    catch (Exception ex)
                    {
                        ImageV.Image = UIImage.FromBundle("Defaultimg");
                    }
                }

                else { ImageV.Image = UIImage.FromBundle("Defaultimg"); }
            }
            catch (Exception ex)
            {

            }
        }
    }
}