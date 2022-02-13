using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DeliveryCart.Models
{
    public class Shopper
    {
        public int ID {get; set;} // PK
        public string ShopperFirstName {get; set;}
        public string ShopperLastName {get; set;}
        public string ShopperEmail {get; set;}
        public string ShopperAddress {get; set;}
        public int ShopperPhoneNumber {get; set;}
        public string ShopperUsername {get; set;}
        public string ShopperPassword {get; set;}
        public ICollection<Order> Orders {get; set;}

    }
}