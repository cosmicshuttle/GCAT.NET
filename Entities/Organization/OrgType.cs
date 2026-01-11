using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GCAT.NET.Entities.Organization
{
    public class OrgType
    {
        [Key]
        [Precision(2)]
        public int OrgTypeID { get; set; }

        [Required]
        public string OrgTypeName { get; set; }
    }
}