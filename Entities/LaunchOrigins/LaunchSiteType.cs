using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.LaunchOrigins
{
    public class LaunchSiteType
    {
        [Key]
        [Length(1, 5)]
        public string LaunchSiteTypeID { get; set; }

        [Required]
        public string LaunchSiteTypeName { get; set; }
    }
}