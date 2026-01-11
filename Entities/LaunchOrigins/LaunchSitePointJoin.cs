using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.LaunchOrigins
{
    public class OrgClassJoin
    {
        [Required]
        public string LaunchSiteCODE { get; set; }

        [ForeignKey(nameof(LaunchSiteCODE))]
        public LaunchSite LaunchSite { get; set; }

        [Required]
        public int LaunchPointCODE { get; set; }

        [ForeignKey(nameof(LaunchPointCODE))]
        public LaunchPoint LaunchPoint { get; set; }
    }
}