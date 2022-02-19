using Xunit;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DeliveryCart;
using DeliveryCart.Models;
using DeliveryCart.Data;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DeliveryCart.Tests;

public class NotImplementedException : SystemException
{
    
}

public class DataAccessLayerTests
{

        [Fact]
        public async Task AddDeliveryPersonAsync_DeliveryPersonIsAdded()
        {
            using (var db = new DbContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;

                var expectedDeliveryPerson = new DeliveryPerson() 
                { 
                    ID = recId, 
                    DeliveryPersonFirstName = "Tester",
                    DeliveryPersonLastName = "Test",
                    DeliveryPersonUsername = "mrtestingdude",
                    DeliveryPersonPassword = "re@llyc00lPassword"
                };

                // Act
                await db.AddDeliveryPersonAsync(expectedDeliveryPerson);

                // Assert
                var actualDeliveryPerson = await db.FindAsync<DeliveryPerson>(recId);
                Assert.Equal(expectedDeliveryPerson, actualDeliveryPerson);
            }
        }

      [Fact]
        public async Task DeleteAllDeliveryPersonAsync_DeliveryPersonAreDeleted()
        {
            using (var db = new DbContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var seedDeliveryPerson =  DbContext.GetSeedingDeliveryPerson();
                await db.AddRangeAsync(seedDeliveryPerson);
                await db.SaveChangesAsync();

                // Act
                await db.DeleteAllDeliveryPersonAsync();

                // Assert
                Assert.Empty(await db.DeliveryPersons.AsNoTracking().ToListAsync());
            }
        }

    

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


