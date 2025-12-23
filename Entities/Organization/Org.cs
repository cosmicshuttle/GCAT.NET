using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GCAT.NET.Entities.Ref;
using GCAT.NET.Entities.Location;

namespace GCAT.NET.Entities.Organization
{
    public class Org
    {
        [Key]
        public string OrgCODE { get; set; }

        [Required]
        public DateTime TStart { get; set; }

        public DateTime TStop { get; set; }

        [Required]
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string EName { get; set; }

        public string UName { get; set; }

        [Required]
        public string StateCODE { get; set; }

        [ForeignKey(nameof(StateCODE))]
        public State State { get; set; }

        [Required]
        public string OrgTypeID { get; set; }

        [ForeignKey(nameof(OrgTypeID))]
        public OrgType OrgType { get; set; }

        [Required]
        public string LocID { get; set; }

        [ForeignKey(nameof(LocID))]
        public Loc Loc { get; set; }
    }
}