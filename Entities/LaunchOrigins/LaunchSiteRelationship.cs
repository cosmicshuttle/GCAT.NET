using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.LaunchOrigins
{
    public class LaunchSiteRelationship
    {
        [Required]
        public int LaunchSiteParentCODE { get; set; }

        [ForeignKey(nameof(LaunchSiteParentCODE))]
        public LaunchSite Parent { get; set; }

        [Required]
        public int LaunchSiteChildCODE { get; set; }

        [ForeignKey(nameof(LaunchSiteChildCODE))]
        public LaunchSite Child { get; set; }

        public string LaunchSiteUCODE { get; set; }

        [Required]
        public int Depth { get; set; }
    }
}