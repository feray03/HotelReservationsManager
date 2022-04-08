using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Clients
{
    public class ClientsCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = " Cannot be more than 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = " Cannot be more than 50 characters")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " The {0} must be {2}")]
        public string PhoneNumber { get; set; }

        [Required]
        public bool IsAdult { get; set; }
    }
}
