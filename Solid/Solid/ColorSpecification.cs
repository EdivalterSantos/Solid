using Solid.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class ColorSpecification : IEspecification<Product>
    {
        private Color Color;

        public ColorSpecification(Color _color)
        {
            Color = _color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == Color;
        }
    }
}
