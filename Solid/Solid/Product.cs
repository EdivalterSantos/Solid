using Solid.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string _name, Color _color, Size _size)
        {
            if (string.IsNullOrEmpty(_name))
            {
                throw new ArgumentNullException(paramName: nameof(_name)); 
            }

            Name = _name;
            Color = _color;
            Size = _size;

        }
    }
}
