using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class PartyDetail
    {
        [Key]
        public string PartyName { get; set; }
        public string Address { get; set; }
        public string GSTNumber { get; set; }

        
    }
}
