using System.ComponentModel.DataAnnotations;

namespace LibManApp.Data.Models
{
    public class Video : LibraryAsset
    {
        [Required] 
        public string Director { get; set; }
    }
}