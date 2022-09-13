using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyInfoApi.Models
{
    public class Info
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        [MaxLength(250)]
        [Required]
        public string MiddleName { get; set; }
        [MaxLength(250)]
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }

        [Required]
        public int GenderId { get; set; }

        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
        [Required]
        public int CastId { get; set; }
        [ForeignKey("CastId")]
        public Cast Cast { get; set; }
        [Required]
        public int MaritialId { get; set; }
        [ForeignKey("MaritialId")]
        public MaritialStatus Maritial { get; set; }
       
        [Required]
        public int MobileNo { get; set; }
    }
}
