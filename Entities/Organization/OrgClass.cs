using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GCAT.NET.Entities.Organization
{
    public class OrgClass
    {
        [Key]
        [Precision(2)]
        public int OrgClassID { get; set; }

        [Required]
        public string OrgClassName { get; set; }
    }
}