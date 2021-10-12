using System;
using System.Collections.Generic;
using System.Text;
using Anegdot;

namespace Global
{
   public static class Program {
        public static BaseShop Shop = new BaseShop();
        public static void Main() {
            var babka = new Babka(Location.Ukraine);
        
            babka.Location = Location.USA;
        
            babka.Languages = new List<Language>() { Language.Ukrainian };

            babka.Want("Манна каша");
            
            babka.Go(Shop);

            Shop.Seller = new Human() { Race = Race.Black };

            babka.Say(Shop.Seller, "Дай манкі");
        }
    };
}