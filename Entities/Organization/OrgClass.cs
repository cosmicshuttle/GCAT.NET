using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAT.NET.Entities.Organization
{
    public class OrgClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassTypeID { get; set; }

        [Required]
        public string ClassName { get; set; }
    }
}