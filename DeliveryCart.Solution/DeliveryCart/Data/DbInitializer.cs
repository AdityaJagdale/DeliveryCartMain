using DeliveryCart.Models;

namespace DeliveryCart.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DbContext context)
        {
            // Look for any DeliveryPersons.
            if (context.DeliveryPersons.Any())
            {
                return;   // DB has been seeded
            }

            var DeliveryPersons = new DeliveryPerson[]
            {
                new DeliveryPerson{ID=1,DeliveryPersonFirstName="Carson",DeliveryPersonLastName="Alexander",DeliveryPersonUsername="calexander",DeliveryPersonPassword="d3liveryC@rt"},
                new DeliveryPerson{ID=2,DeliveryPersonFirstName="Meredith",DeliveryPersonLastName="Alonso",DeliveryPersonUsername="malonso",DeliveryPersonPassword="rufus123"},
                new DeliveryPerson{ID=3,DeliveryPersonFirstName="Arturo",DeliveryPersonLastName="Anand",DeliveryPersonUsername="aanand",DeliveryPersonPassword="rock456"},
                new DeliveryPerson{ID=4,DeliveryPersonFirstName="Gytis",DeliveryPersonLastName="Barzdukas",DeliveryPersonUsername="gearzdukas",DeliveryPersonPassword="Agd034nx#sd%"},
                new DeliveryPerson{ID=5,DeliveryPersonFirstName="Yan",DeliveryPersonLastName="Li",DeliveryPersonUsername="yli",DeliveryPersonPassword="iLOVEPUPPIES4EVER"},
                new DeliveryPerson{ID=6,DeliveryPersonFirstName="Peggy",DeliveryPersonLastName="Justice",DeliveryPersonUsername="pjustice",DeliveryPersonPassword="d#5fDk2%"},
                new DeliveryPerson{ID=7,DeliveryPersonFirstName="Laura",DeliveryPersonLastName="Norman",DeliveryPersonUsername="lnorman",DeliveryPersonPassword="br@1n$t0rM"},
                new DeliveryPerson{ID=8,DeliveryPersonFirstName="Nino",DeliveryPersonLastName="Olivetto",DeliveryPersonUsername="nolivetto",DeliveryPersonPassword="password"}
            };

            context.DeliveryPersons.AddRange(DeliveryPersons);
            context.SaveChanges();
        }
    }
}