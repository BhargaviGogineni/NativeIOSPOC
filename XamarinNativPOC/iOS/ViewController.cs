using System;
using System.Threading.Tasks;
using Refit;
using UIKit;
using XamarinNativPOC.iOS.Services;

namespace XamarinNativPOC.iOS
{
    public partial class ViewController : UIViewController
    {
        private UIRefreshControl refreshControl;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LoadData();

        }

        private async Task LoadData()
        {
            acticityindicator.StartAnimating();

            var speciesService = RestService.For<ISpeciesApi>("https://dl.dropboxusercontent.com");

            var apiData = await speciesService.GetSpecies();

            
            if (apiData != null && apiData.rows != null)
            {
                TableView.DataSource = new TableviewDataSource(apiData.rows);
                TableView.ReloadData();
            }

            acticityindicator.StopAnimating();
            acticityindicator.Hidden = true;

            refreshControl = new UIRefreshControl();

            // Handle the pullDownToRefresh event
            refreshControl.ValueChanged += refreshTable;

            // Add the UIRefreshControl to the TableView
            TableView.AddSubview(refreshControl);
        }

        private void refreshTable(object sender, EventArgs e)
        {
            LoadData();
            refreshControl.EndRefreshing();
            TableView.ReloadData();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
