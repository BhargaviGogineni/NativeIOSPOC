using Foundation;
using Refit;
using System;
using System.Threading.Tasks;
using UIKit;
using XamarinNativPOC.iOS.Services;

namespace XamarinNativPOC.iOS
{
    public partial class TvController : UIViewController
    {
        private UIRefreshControl refreshControl;


        public TvController(IntPtr handle) : base(handle)
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
                tableView.DataSource = new TvDataSource(apiData.rows);
                tableView.ReloadData();
            }

            busyindicator.StopAnimating();
            busyindicator.Hidden = true;

            refreshControl = new UIRefreshControl();

            // Handle the pullDownToRefresh event
            refreshControl.ValueChanged += refreshTable;

            // Add the UIRefreshControl to the TableView
            tableView.AddSubview(refreshControl);
        }

        private void refreshTable(object sender, EventArgs e)
        {
            LoadData();
            refreshControl.EndRefreshing();
            tableView.ReloadData();
        }

    }
}