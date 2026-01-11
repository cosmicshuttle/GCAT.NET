using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.LaunchOrigins
{
    public class LaunchPointRelationship
    {
        [Required]
        public int LaunchPointParentCODE { get; set; }

        [ForeignKey(nameof(LaunchPointParentCODE))]
        public LaunchPoint Parent { get; set; }

        [Required]
        public int LaunchPointChildCODE { get; set; }

        [ForeignKey(nameof(LaunchPointChildCODE))]
        public LaunchPoint Child { get; set; }

        public string LaunchPointUCODE { get; set; }

        [Required]
        public int Depth { get; set; }
    }
}