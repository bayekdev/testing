using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyInfoApi.Models
{
    public class MaritialStatus
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
