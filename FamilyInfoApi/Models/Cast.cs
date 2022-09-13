using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyInfoApi.Models
{
    public class Cast
    {
        [Key]
        public int Id { get; set; }
        public string CastName { get; set; }
        public int CastCode { get; set; }
    }
}
