using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samostoyatel_naya_01._03._23
{
    // заданиеп 2
    public class Mobile
    {

        private int _series;
        private DateTime _dateOfMade;
        private string _countryOfMade;
        private int _numberOfVersionAndroid;
        private int _quantityOfMemory;

        public int Series // 1 свойство
        {
            get { return _series; }
            set { _series = value; }
        }
        public DateTime DateOfMade // 2 свойство
        {
            get { return _dateOfMade; }
            set { _dateOfMade = value; }
        }
        public string CountryOfMade // 3 свойство
        {
            get { return _countryOfMade; }
            set { _countryOfMade = value; }
        }
        public int NumberOfVersionAndroid // 4 свойство
        {
            get { return _numberOfVersionAndroid; }
            set { _numberOfVersionAndroid = value; }
        }
        public int QuantityOfMemory // 5 свойство
        {
            get { return _quantityOfMemory; }
            set { _quantityOfMemory = value; }
        }
        public void ShowSeries() // 1 метод
        {
            Console.WriteLine("Серия телефона: " + Series);
        }
        public void ShowCountryOfMade() // 2 метод
        {
            Console.WriteLine("Изготовился в городе: " + CountryOfMade);
        }
        public void ShowAllInfo() // 3 метод
        {
            Console.WriteLine("Информация о телефоне: " + Series + DateOfMade + CountryOfMade + NumberOfVersionAndroid + QuantityOfMemory);
        }
       
        public Mobile (int _series, DateTime _dateOfMade, string _CountryOfMade, int _NumberOfVersionAndroid, int _QuantityOfMemory) // Конструктор
        {
            Series = _series;
            DateOfMade = _dateOfMade;
            CountryOfMade = _countryOfMade;
            NumberOfVersionAndroid = _numberOfVersionAndroid;
            QuantityOfMemory = _QuantityOfMemory;

        }



    }
}
