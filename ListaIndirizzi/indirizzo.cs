using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi {
    public class indirizzo {

        private string Name;
        private string Surname;
        private string Street;
        private string City;
        private string Province;
        private string ZIP;

        public indirizzo(string Name, string Surname, string Street,string City,string Province,string ZIP) {
            this.Name=Name;
            this.Surname=Surname;
            this.Street=Street;
            this.City = City;
            this.Province = Province;
            this.ZIP = ZIP;
        }

        public string GetName() {
            return Name;
        }

        public void SetName(string value) {
            Name = value;
        }

        public string GetSurname() {
            return Surname;
        }

        public void SetSurname(string value) {
            SetSurname(value);
        }

        public string GetStreet() {
            return Street;
        }

        public void SetStreet(string value) {
            Street = value;
        }
        public string GetCity() {
            return City;
        }

        public void SetCity(string value) {
            City = value;
        }
        public string GetProvince() {
            return Province;
        }

        public void SetProvince(string value) {
            Province = value;
        }
        public string GetZIP() {
            return ZIP;
        }

        public void SetZIP(string value) {
            ZIP = value;
        }

        public override string ToString() {
            string print = GetName() + "\n";
            print += GetSurname() + "\n";
            print += GetStreet() + "\n";
            print += GetCity() + "\n";
            print += GetProvince() + "\n";
            print += GetZIP() + "\n";
            return print;
        }
    }
}
