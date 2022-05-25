using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectOfYourAffection
{
    internal class Profile
    {
        //fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // Constructors
        public Profile(string name, int age, string city, string country, string pronouns)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }

        // Propeties



        //methods

        public string ViewProfile()
        {
            string profileInformations = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\nHobbies: {hobbies}";
            
            profileInformations += "\nHobbies:\n";

            foreach (string hobby in hobbies)
            {
                profileInformations += $"-{hobby}\n";
            }

            return profileInformations;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies=hobbies;   
        }
    }
}
