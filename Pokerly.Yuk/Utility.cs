using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Pokerly.Yuk
{
    static class RandomExtensions
    {
        public static void Shuffle<ArrayList>(this Random rng, System.Collections.ArrayList array)
        {
            int n = array.Count;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Object temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
