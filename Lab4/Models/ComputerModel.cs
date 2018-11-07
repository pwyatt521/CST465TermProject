using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab4.Models{
   public class ComputerModel{
       
        [RegularExpression("^[a-zA-Z \\-]{2,20}$", ErrorMessage="Must be 2-20 characters")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name {get; set;}

        [Required(ErrorMessage="Please enter a Password")]
        [DataType(DataType.Password)]
        public string Password {get; set;}

        [RegularExpression("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}",ErrorMessage="Must be in propper IP form")]
        public string IPAddress {get; set;}

        public string Location {get; set;}
        [Required(ErrorMessage="Please enter an OS")]
        [UIHint("OSDropdown")]
        public string OS {get; set;}

        public string Description {get; set;}
        [RegularExpression("[1234]", ErrorMessage="Must 1, 2, 3, or 4")]

        [Required(ErrorMessage = "Select an amount of Monitors please")]
        public int SupportedMonitors {get; set;}

        public static readonly List<string> OSTypes = new List<string>{
            "IOS", "Windows", "Linux"
        };

   } 
}