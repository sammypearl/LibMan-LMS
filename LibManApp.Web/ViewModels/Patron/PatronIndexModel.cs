using System.Collections.Generic;

namespace LibManApp.Web.ViewModels.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; }
    }
}