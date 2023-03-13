using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    internal class Group
    {
        private string _titleGroup;

        public string TitleGtoup
        {
            get => _titleGroup;
        }

        public  Group(string titleGroup)
        {
            _titleGroup = titleGroup;
        }
    }
}
