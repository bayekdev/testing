using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Gender { get; set; }
        [Required]
        public string Cast { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        public int MobileNo { get; set; }
    }
}
