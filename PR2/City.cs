using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    internal class City
    {
        private string _cityName;

        public string CityName
        {
            get => _cityName;


        }

        public  City(string cityName)
        {
            _cityName = cityName;
        }
    }
}
