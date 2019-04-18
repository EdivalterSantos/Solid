using Solid.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class SizeSpecification : IEspecification<Product>
    {
        private Size Size;

        public SizeSpecification(Size _size)
        {
            Size = _size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == Size;
        }
    }
}
