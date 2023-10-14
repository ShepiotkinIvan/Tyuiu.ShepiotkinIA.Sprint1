using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShepiotkinIA.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            string sortedValue = SortLettersAlphabetically(value);
            return value.Equals(sortedValue, StringComparison.OrdinalIgnoreCase);
        }

        private string SortLettersAlphabetically(string value)

        {
            char[] letters = value.ToLower().ToCharArray();
            Array.Sort(letters);
            return new string(letters);
        }
    }
}
