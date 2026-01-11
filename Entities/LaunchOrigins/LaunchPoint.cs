using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GCAT.NET.Entities.Ref;
using Microsoft.EntityFrameworkCore;

namespace GCAT.NET.Entities.LaunchOrigins
{
    public class LaunchPoint
    {
        [Key]
        public string LaunchPointCODE { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime TStart { get; set; }

        public DateTime TStop { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string LaunchPointTypeID { get; set; }

        [ForeignKey(nameof(LaunchPointTypeID))]
        public LaunchPointType LaunchPointType { get; set; }


        [Required]
        public string LocationID { get; set; }

        [ForeignKey(nameof(LocationID))]
        public Location Location { get; set; }
    }
}