using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeFactorKata
{
    public class PrimeFactor
    {
        public IEnumerable<int> GetList(int n)
        {
            IList<int> back = new List<int>();
            if (1 < n)
            {
                while (0 == (n % 2))
                {
                    back.Add(2);
                    n /= 2;
                }
                if (1 < n)
                {
                    back.Add(n);
                }
            }
            return back;
        }
    }
}
