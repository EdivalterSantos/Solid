using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    interface IEspecification<T>
    {
        bool IsSatisfied(T t);
    }
}
