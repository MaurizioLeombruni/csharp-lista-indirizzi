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

        private bool isInvalid = false;

        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;

            //Questi if invalidano l'indirizzo e, alla scrittura, printano un messaggio di errore piuttosto che un indirizzo incompleto.
            //È la soluzione più semplice e veloce, anche se piuttosto meno elegante.

            //Se si rendono commenti questi due if, il programma stampa anche gli indirizzi invalidi, solo con campi vuoti.

            if(name == null || surname == null || street == null || city == null || province == null || zip == null)
            {
                SetValidState(true);
            }

            if (name == "" || surname == "" || street == "" || city == "" || province == "" || zip == "")
            {
                SetValidState(true);
            }
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

        public void PrintAddress()
        {
            if (!isInvalid)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Nome:\t\t" + GetName());
                Console.WriteLine("Cognome: \t"+ GetSurname());
                Console.WriteLine("Via:\t\t" + GetStreet());
                Console.WriteLine("Città:\t\t" + GetCity());
                Console.WriteLine("Provincia:\t" + GetProvince());
                Console.WriteLine("ZIP:\t\t" + GetZipCode());
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Invalid or missing address");
            }
        }
    }
}
