using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    internal class EducationForm
    {
        private string _educForm;

        public string EducForm
        {
            get => _educForm;
        }

        public  EducationForm(string educForm)
        {
            _educForm = educForm;
        }
    }
}
