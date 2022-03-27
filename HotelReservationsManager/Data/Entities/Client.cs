using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
    public class Client :BaseEntity
    {
        public Client()
        {

        }

        public Client(Client client)
        {
            Id = client.Id;
            FirstName = client.FirstName;
            LastName = client.LastName;
            PhoneNumber = client.PhoneNumber;
            Email = client.Email;
            IsAdult = client.IsAdult;
            ClientReservations = client.ClientReservations;
        }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        public bool IsAdult { get; set; }
        public virtual ICollection<ClientReservation> ClientReservations { get; set; }
    }
}
