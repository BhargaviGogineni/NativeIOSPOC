using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using XamarinNativPOC.iOS.Models.Responses;

namespace XamarinNativPOC.iOS
{
    public class TableviewDataSource : UITableViewDataSource
    {
        private List<Species> rows;

        public TableviewDataSource(List<Species> rows)
        {
            this.rows = rows;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (CustomCell)tableView.DequeueReusableCell("cell_id", indexPath);
            var data = rows[indexPath.Row];
            cell.UpdateCell(data);
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return rows.Count;
        }

    }
}
