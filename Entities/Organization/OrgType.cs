using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.Organization
{
    public class OrgType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrgTypeID { get; set; }

        [Required]
        public string OrgTypeName { get; set; }
    }
}