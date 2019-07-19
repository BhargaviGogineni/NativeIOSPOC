using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using XamarinNativPOC.iOS.Models.Responses;

namespace XamarinNativPOC.iOS
{
    public class CollectionViewdatasource : UICollectionViewDataSource
    {
        private List<Species> rows;
        public CollectionViewdatasource(List<Species> rows)
        {
            this.rows = rows;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (CustomCollectionViewCell)collectionView.DequeueReusableCell("CustomCellID", indexPath);
            var data = rows[indexPath.Row];
            cell.UpdateCell(data);
            return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return rows.Count;
        }

         
    }
}