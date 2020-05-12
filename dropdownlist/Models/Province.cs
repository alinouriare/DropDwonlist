using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dropdownlist.Models
{
    public class Province
    {
        [Key]
        public int ID { get; set; }


        public string ProvinceName { get; set; }
    }
}
