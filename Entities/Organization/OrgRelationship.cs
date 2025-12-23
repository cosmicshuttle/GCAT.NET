using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.Organization
{
    public class OrgRelationship
    {
        [Required]
        public int OrgParentCODE { get; set; }

        [ForeignKey(nameof(OrgParentCODE))]
        public Org Parent { get; set; }

        [Required]
        public int OrgChildCODE { get; set; }

        [ForeignKey(nameof(OrgChildCODE))]
        public Org Child { get; set; }

        public string OrgUCODE { get; set; }

        [Required]
        public int Depth { get; set; }
    }
}