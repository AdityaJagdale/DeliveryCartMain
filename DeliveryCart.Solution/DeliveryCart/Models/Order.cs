using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DeliveryCart.Models
{
    public class Order
    {
        public int ID {get; set;} // PK
        public int ShopperID {get; set;} // FK
        public string OrderDescription {get; set;}
        public string StoreRequested {get; set;}
        public bool OrderCompleted {get; set;}
        public double OrderTotal {get; set;}
        public DateTime OrderDate {get; set;}
        public Shopper Shopper {get; set;}

        // Navigation Property for the Order_DeliveryPerson associative table.
        // public ICollection<OrderDeliveryPerson> OrderDeliveryPersons {get; set;}

    }
}