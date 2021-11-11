using IndivisibleArkansasStatistics.Data;
using IndivisibleArkansasStatistics.Models;
using System;
using System.Linq;

namespace IndivisibleArkansasStatistics.Data
{
    public static class DBInitializer
    {
        public static void Initialize(IndivisibleArkansasStatisticsContext context)
        {
            // Look for any students.
            if (context.Contacts.Any())
            {
                return;   // DB has been seeded
            }


            var contactos = new Contact[]
            {
                new Contact{F_name="Carson",L_name="Alexander",Address="1600 Washington Ave", City="Conway", County="Faulkner", State="Arkansas", Zip = 72032, ContactId=1},
                new Contact{F_name="Meredith",L_name="Alonso",Address="1 Missouri Ave", City="St. Louis", County="St. Louis", State="Missouri", Zip = 63132, ContactId=2},
                new Contact{F_name="Arturo",L_name="Anand",Address="32 Indivisble St", City="Little Rock", County="Pulaski", State="Arkansas", Zip =72002, ContactId=3},
                new Contact{F_name="Gytis",L_name="Barzdukas",Address="Lemur Dr", City="Little Rock", County="Pulaski", State="Arkansas", Zip =72002, ContactId=4}
            };

            context.Contacts.AddRange(contactos);
            context.SaveChanges();


            var locationos = new Location[]
            {
                new Location{Loc="Central High School",LocationId=1},
                new Location{Loc="City Hall",LocationId=2},
                new Location{Loc="Hendrix College",LocationId=3},
                new Location{Loc="The Park",LocationId=4},
            };

            context.Locations.AddRange(locationos);
            context.SaveChanges();


            var interestos = new Interest[]
            {
                new Interest{Interests="Gun Control",InterestId=1},
                new Interest{Interests="Education",InterestId=2},
                new Interest{Interests="Taxation",InterestId=3},
                new Interest{Interests="Discrimination",InterestId=4},
            };

            context.Interests.AddRange(interestos);
            context.SaveChanges();
        }
    }
}