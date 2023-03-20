using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractice.Services
{
    public class TipCalculationService
    {
        public double GetTip(int billAmount)
        {
            if (billAmount > 0 && billAmount <= 50)
            {
                return 5.0;
            }
            else if (billAmount > 50 && billAmount <= 100)
            {
                return billAmount * 0.10;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
