using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class AndSpecification<T> : IEspecification<T>
    {

        private IEspecification<T> First, Second;
        public AndSpecification(IEspecification<T> first, IEspecification<T> second)
        {          
            First = first;
            Second = second;

        } 
        public bool IsSatisfied(T t)
        {
            return First.IsSatisfied(t) && Second.IsSatisfied(t);
        }
    }
}
