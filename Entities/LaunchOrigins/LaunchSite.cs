using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GCAT.NET.Entities.Ref;
using GCAT.NET.Entities.Organization;
using Microsoft.EntityFrameworkCore;

namespace GCAT.NET.Entities.LaunchOrigins
{
    public class LaunchSite
    {
        [Key]
        public string LaunchSiteCODE { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime TStart { get; set; }

        public DateTime TStop { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string OrgCODE { get; set; }

        [ForeignKey(nameof(OrgCODE))]
        public Org Org { get; set; }


        [Required]
        public string StateCODE { get; set; }

        [ForeignKey(nameof(StateCODE))]
        public State State { get; set; }


        [Required]
        public string LaunchSiteTypeID { get; set; }

        [ForeignKey(nameof(LaunchSiteTypeID))]
        public LaunchSiteType LaunchSiteType { get; set; }


        [Required]
        public string LocationID { get; set; }

        [ForeignKey(nameof(LocationID))]
        public Location Location { get; set; }
    }
}