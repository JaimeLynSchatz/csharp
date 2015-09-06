using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNL
{
    class ClothingClass
    {
        private string _color;
        private string _size;

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public string Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
            }
        }
    }
}
