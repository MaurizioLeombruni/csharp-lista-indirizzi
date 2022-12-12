using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpListaIndirizzi
{
    public class Address
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;

        private bool isInvalid = true;

        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetStreet()
        {
            return street;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetProvince()
        {
            return province;
        }

        public string GetZipCode()
        {
            return zip;
        }

        public void SetValidState(bool value)
        {
            isInvalid = value;
        }
    }
}
