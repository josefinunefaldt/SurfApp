using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp5.Data.Entities
{
    [Index(nameof(Fav_username), IsUnique = true)]
    public class Favourites
    {
        [Key]
        public int Fav_Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(50)]
        [RegularExpression(@"^[^åäöÅÄÖ]+$", ErrorMessage = "Invalid characters")]
        public string Fav_username { get; set; }

        [Required(ErrorMessage = "spotname is required")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(50)]
        [RegularExpression(@"^[^åäöÅÄÖ]+$", ErrorMessage = "Invalid characters")]
        public string Fav_user_spotname { get; set; }

        [AllowNull]
        public string Fav_latitude { get; set; }

        [AllowNull]
        public string Fav_longitude { get; set; }

        [AllowNull]
        [Required(ErrorMessage = "spot is required")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100)]
        [RegularExpression(@"^[^åäöÅÄÖ]+$", ErrorMessage = "Invalid characters")]
        public string Fav_description { get; set; }

        public string Fav_location { get; set; }

        public DateTime Fav_created_at { get; set; }
    }
}
