using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.Organization
{
    public class OrgClassJoin
    {
        [Required]
        public string OrgCODE { get; set; }

        [ForeignKey(nameof(OrgCODE))]
        public Org Org { get; set; }

        [Required]
        public int OrgClassID { get; set; }

        [ForeignKey(nameof(OrgClassID))]
        public OrgClass Class { get; set; }
    }
}