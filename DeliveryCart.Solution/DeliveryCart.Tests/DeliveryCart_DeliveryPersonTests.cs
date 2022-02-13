using Xunit;
using System;
using System.Text.RegularExpressions;
using DeliveryCart;
using DeliveryCart.Models;
using DeliveryCart.Data;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DeliveryCart.Tests.Models;

public class NotImplementedException : SystemException
{
    
}

public class DeliveryPerson_AttributesShould
{

    [Fact]
    public bool DeliveryPerson_FirstNameConstraints()
    {
        
        DeliveryPerson dp1 = new DeliveryPerson{DeliveryPersonFirstName = "Rex"};

        int fn = dp1.DeliveryPersonFirstName.Length;
        
        // int fn = 5; # testing variable
        if ( fn >= 2 && fn <= 40)
        {
            return true;
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    [Fact]
    public bool DeliveryPerson_LastNameConstraints()
    {
       
        DeliveryPerson dp2 = new DeliveryPerson{DeliveryPersonLastName = "RexBland"};

        int nm = dp2.DeliveryPersonLastName.Length;
        // char x = (@"[0-9]+");
        
        if(nm >= 2 && nm <= 40)
        {
            return true;
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    [Fact]
    public bool DeliveryPerson_UsernameConstraints()
    {
        DeliveryPerson em1 = new DeliveryPerson{DeliveryPersonUsername = "Aj"};

        int ep = em1.DeliveryPersonUsername.Length;

        if(ep >= 2 && ep <= 40)
        {
            return true;
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    [Fact]
    public bool DeliveryPerson_PasswordConstraints()
    {
        DeliveryPerson ps1 = new DeliveryPerson{DeliveryPersonPassword = "a1!EUS"};
        
        int p = ps1.DeliveryPersonPassword.Length;
        
        if(p >= 6 && p <= 20)
        {
            return true;
        }
        else
        {
            throw new NotImplementedException();
        }

    }

}


