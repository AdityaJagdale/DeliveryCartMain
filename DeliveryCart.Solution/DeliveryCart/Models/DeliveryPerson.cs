using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DeliveryCart.Models
{

    public class DeliveryPerson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID {get; set;} // PK

        [Required]
        public string DeliveryPersonFirstName {get; set;}
        public string DeliveryPersonLastName {get; set;}
        public string DeliveryPersonUsername {get; set;}
        public string DeliveryPersonPassword {get; set;}

        // Navigation Property for the Order_DeliveryPerson associative table.
        public ICollection<OrderDeliveryPerson> OrderDeliveryPersons {get; set;}

        // Backlogged for now.
        // public int DeliveryPersonRating {get; set;}
        // public datetime DeliveryPersonHireDate {get; set;}

    }

    public class OrderDeliveryPerson
        {
            public int ID {get; set;}
            public int OrderID {get; set;} // Composite PK, FK1
            public int DeliveryPersonID {get; set;} // Composite PK, FK2
            public Order Order {get; set;} // Navigation Property. 1 order to 1 ODP
            public DeliveryPerson DeliveryPerson {get; set;} // Navigation Property. 1 Delivery person to 1 ODP
        }
    }