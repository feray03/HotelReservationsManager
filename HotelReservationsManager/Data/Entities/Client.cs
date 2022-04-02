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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public bool IsAdult { get; set; }
        public virtual ICollection<ClientReservation> ClientReservations { get; set; }
    }
}
