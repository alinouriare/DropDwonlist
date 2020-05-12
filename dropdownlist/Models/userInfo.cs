using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dropdownlist.Models
{
    public class userInfo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "شهر")]
        public int CityID { get; set; }

        [Display(Name = "استان")]
        public int ProvinceID { get; set; }


        [ForeignKey("CityID")]
        public virtual City cy { get; set; }
    }
}
