using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.LaunchOrigins
{
    public class LaunchPointType
    {
        [Key]
        [Length(1, 5)]
        public string LaunchPointTypeID { get; set; }

        [Required]
        public string LaunchPointTypeName { get; set; }
    }
}