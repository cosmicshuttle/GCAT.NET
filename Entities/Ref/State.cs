using System.ComponentModel.DataAnnotations;

namespace GCAT.NET.Entities.Ref
{
    public class State
    {
        [Key]
        public string StateCODE { get; set; }

        [Required]
        public string StateName { get; set; }
    }
}