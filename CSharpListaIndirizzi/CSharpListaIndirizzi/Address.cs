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
    }
}
