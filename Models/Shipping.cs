using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myfirstproject.Models
{
    public class Shipping
    {
        [Key]
        public int ShippingId { get; set; }

        [Required(ErrorMessage = "Fill up this form!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Fill up this form!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Fill up this form!")]
        public string Company { get; set; }

        [Required, StringLength(100)]
        public string Address { get; set; }

        [Required, StringLength(50)]
        public string City { get; set; }

        [Required]
        public int PostalCode { get; set; }

        [Required]
        public int Phone { get; set; }

    }
}
