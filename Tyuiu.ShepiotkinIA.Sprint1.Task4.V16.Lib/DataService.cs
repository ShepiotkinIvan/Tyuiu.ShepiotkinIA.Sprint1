using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShepiotkinIA.Sprint1.Task4.V16.Lib
{
    public class DataService : ISprint1Task4V16
    {
        public double Calculate(double x)
        {
            var res = (1 / (x + 4));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
