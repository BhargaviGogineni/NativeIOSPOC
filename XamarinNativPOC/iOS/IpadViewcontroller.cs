using Foundation;
using Refit;
using System;
using System.Threading.Tasks;
using UIKit;
using XamarinNativPOC.iOS.Services;

namespace XamarinNativPOC.iOS
{
    public partial class IpadViewcontroller : UIViewController
    {
        public UIRefreshControl refreshControl;
        public IpadViewcontroller (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            busyindicator.StartAnimating();
            LoadData();
        }

        private async Task LoadData()
        {

            var speciesService = RestService.For<ISpeciesApi>("https://dl.dropboxusercontent.com");

            var apiData = await speciesService.GetSpecies();


            if (apiData != null && apiData.rows != null)
            {
                collectionView.DataSource = new CollectionViewdatasource(apiData.rows);
                collectionView.ReloadData();
            }

            busyindicator.StopAnimating();
            busyindicator.Hidden = true;

            refreshControl = new UIRefreshControl();
            collectionView.AddSubview(refreshControl);

            refreshControl.ValueChanged += RefreshControl_ValueChanged;
        }

        private void RefreshControl_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
            refreshControl.EndRefreshing();
            collectionView.ReloadData();
        }
    }
}