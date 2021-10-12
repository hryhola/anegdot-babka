using System;
using System.Collections.Generic;
using System.Text;

namespace Anegdot
{
    public enum Race
    {
        White,
        Black
    }
    public class Human
    {
        public Race Race;
        public virtual void Say(Human whom, string what) { }
    }
    public abstract class Place
    {
        public string Name;
        public List<Human> HumanList;
    }
    public class BaseShop : Place
    {
        public BaseShop() { this.HumanList = new List<Human>(); this._seller = new Human(); }
        private Human _seller;
        public Human Seller
        {
            set
            {
                Console.WriteLine("А продавець в магазині " + value.Race);
                this._seller = value;
            }
            get
            {
                return this._seller;
            }
        }
        public override string ToString()
        {
            return "Магазин";
        }
    }
    public enum Location
    {
        Ukraine,
        USA
    }
    public enum Language
    {
        American,
        Ukrainian
    }
    public class Babka : Human
    {
        public Babka(Location locatoin)
        {
            Console.WriteLine("Була бабка в " + locatoin);
            this._location = locatoin;

            if (locatoin == Location.Ukraine)
            {
                this.Race = Race.White;
            }
        }
        public void Want(string what)
        {
            Console.WriteLine("Захотілось бабці " + what);
            this._wants = what;
        }
        public void Go(Place place)
        {
            Console.WriteLine("Пішла бабка в " + place);
            place.HumanList.Add(this);
        }
        public override void Say(Human whom, string what)
        {
            base.Say(whom, what);
            Console.WriteLine("І тут бабка каже: " + what);
        }

        private Location _location;
        public Location Location
        {
            set
            {
                Console.WriteLine("Прилетіла бабка в " + value);
                this._location = value;
            }

        }
        private List<Language> _languages;
        public List<Language> Languages
        {
            set
            {
                Console.WriteLine("Знає бабка тільки " + value[0]);
                this._languages = value;
            }
        }
        private string _wants;
    }
}