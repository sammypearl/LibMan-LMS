using System.Collections.Generic;

namespace LibManApp.Web.ViewModels.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}