using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ZegarekMVC.Models
{
    public class DataForm
    {
        [Required]
        [DataType(DataType.Time)]     
        [DefaultValue("12")]
        public DateTime Godzina { get; set; }


        public double KatStopnie{get;set;}
        public double KatRadiany { get; set; }

    }
}