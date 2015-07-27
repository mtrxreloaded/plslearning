using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CodedHomes.Models;
using System.Data.Entity;


namespace CodedHomes.Data.Configuration
{
    public class CustomDatabaseInitializer : 
        CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            string[] descriptions = new string[10] {
                "Nice neightborhood with friendly neighbors.",
                "A truly beautiful home!",
                "In a cul-de-dac on a quiet stree.",
                "Freeway accessible with a huge green lawn.",
                "Lots of storage and big bedrooms.",
                "Well-kept by previous owners.",
                "Includes pool, spa and basketball hoop.",
                "The back fence needs some work, but the house is in great condition.",
                "Includes a huge bonus room great for an office or playroom.",
                "Close to local magnet schools."
            };

            int count = 10;
            while ((count--) != 0)
            {
                Home home = new Home();
                home.StreetAddress = string.Format("12{0} Street St.", count);
                home.City = "Anytown";
                home.ZipCode = 91765;
                home.Bedrooms = ((count % 2) == 1) ? 4 : 3;
                home.Bathrooms = home.Bedrooms - 2;
                home.SquareFeet = 3700 + count;
                home.Price = 275000 + (count * 1000);
                home.ImageName = string.Format("home-{0}.jpg", ((count % 2) == 1) ? 1 : 0 );
                home.Description = descriptions[count];
                context.Homes.Add(home);
            }

            base.Seed(context);
        }
    }
}
