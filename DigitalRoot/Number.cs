using System;

namespace DigitalRoot
{
    /// <summary>
    /// Codekata: Digital root
    /// A digital root is the recursive sum of all the numbers in a number.
    /// If the result have 2 digits or more - reduce it again, fx
    /// DigitalRoot(16) => 1+6 => 7
    /// DigitalRoot(942) => 9+4+2 => 15 => 1+5 => 6
    /// DigitalRoot(132189) => 1+3+2+1+8+9 => 24 => 2+4 => 6
    /// </summary>
    public class Number
    {
        public int DigitalRoot(long n)
        {
            int result = (int)n;

            while (result >= 10)
            {
                result = AddNumbers(result);
            }
            
            
            return result;
        }

        private int AddNumbers(long number)
        {
            int result = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                result += Convert.ToInt32(number.ToString().Substring(i, 1));
            }

            return result;
        }
    }
}