using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.Location
{
    public class Loc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocID { get; set; }

        [Required]
        public float Lat { get; set; }

        [Required]
        public float Lon { get; set; }

        [Required]
        public float Error { get; set; }
    }
}