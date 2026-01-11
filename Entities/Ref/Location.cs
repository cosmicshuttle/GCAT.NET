using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.Ref
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationID { get; set; }

        [Required]
        public string City { get; set; }

        public string Area { get; set; }

        [Required]
        public float Lat { get; set; }

        [Required]
        public float Lon { get; set; }
    }
}