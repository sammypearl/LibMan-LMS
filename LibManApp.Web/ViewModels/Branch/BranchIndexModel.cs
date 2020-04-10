using System.Collections.Generic;

namespace LibManApp.Web.ViewModels.Branch
{
    public class BranchIndexModel
    {
        public IEnumerable<BranchDetailModel> Branches { get; set; }
    }
}