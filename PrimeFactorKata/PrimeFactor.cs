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
            for (int factor = 2, lim = n; 1 < n; factor++)
                for (; 0 == (n % factor); n /= factor)
                    back.Add(factor);
            return back;
        }
    }
}
