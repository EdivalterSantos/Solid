using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, IEspecification<T> spec);
    }
}
