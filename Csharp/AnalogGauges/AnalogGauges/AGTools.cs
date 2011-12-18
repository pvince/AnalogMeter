using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace AnalogGauges
{
    class AGTools
    {

        public static int averageArray(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }

            return total / array.Length;
        }
    }
}
