using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZadanie6
{
    internal class Osoba : INotifyPropertyChanged
    {
        private string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; ZmianaInterfejsu("Opis"); }
        }
        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; ZmianaInterfejsu("Opis"); }
        }
        private string? email;
        public string? Email
        {
            get { return email; }
            set { email = value; ZmianaInterfejsu("Opis"); }
        }
        public decimal? kwota_wplaty { get; set; }
        public string? region { get; set; }
        public int? poziom_dostepu { get; set; }

        public Osoba()
        {

        }
        public Osoba(string i, string n, string? e, decimal? k_w, string? r, int? p_d)
        {
            imie = i;
            nazwisko = n;
            email = e;
            kwota_wplaty = k_w;
            region = r;
            poziom_dostepu = p_d;
        }

        public string Opis { 
            get
            {
                return imie + " " + nazwisko + " " + "(" + email + ")";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void ZmianaInterfejsu(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public override string ToString()
        {
            return imie + " " + nazwisko + " " + "(" + email + ")";
        }
    }
}
