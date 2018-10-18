using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models{
   public class ContactModel{
       
       [Required(ErrorMessage = "Name is Required")]
        public string name {get; set;}
        public string phoneNumber{get; set;}
        [Required(ErrorMessage = "Email is Required")]
        public string email{get; set;}
       [Required(ErrorMessage = "Message is Required")]
       public string message{get; set;}
   } 
}