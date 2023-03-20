using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractice.Services
{
    public class PrimeServices
    {
        public bool IsPrime(int num)
        {
            if(num < 2)
            {
                return false;
            }

            int i;
            for(i = 2; i < num/2; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
