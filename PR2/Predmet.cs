using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    internal class Predmet
    {
        private string _predmetName;

        public string PredmetName
        {
            get => _predmetName;
            set => _predmetName = value;
        }

        public Predmet(string predmetName)
        {
            _predmetName = predmetName;
        }
    }
}
