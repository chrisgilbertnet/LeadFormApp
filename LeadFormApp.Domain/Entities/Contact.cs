using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LeadFormApp.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide your first name.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must provide your last name.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide your address.")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Address 2")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "You must provide your city.")]
        [DisplayName("City")]
        public string City { get; set; }

        [Required(ErrorMessage = "You must provide your state/province.")]
        [DisplayName("State/Province")]
        public string State { get; set; }

        [Required(ErrorMessage = "You must provide your zip/postal code.")]
        [DisplayName("Zip/Postal Code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "You must provide your email address.")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}