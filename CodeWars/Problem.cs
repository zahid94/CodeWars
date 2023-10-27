using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Problem
    {
        /// <summary>
        /// Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// XO("ooxx") => true
        /// XO("xooxx") => false
        /// XO("ooxXm") => true
        /// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
        /// XO("zzoo") => false
        /// </returns>
        public bool XO(string input) // my solved
        {
            input = input.ToLower();

            char[] chars = input.ToCharArray();

            if (!chars.Any(x => (new char[] { 'x', 'o' }).Contains(x)))
            {
                return true;
            }

            if (!chars.Contains('x'))
            {
                return false;
            }

            if (!chars.Contains('o'))
            {
                return false;
            }

            int x = chars.Where(x => x == 'x').Count();
            int o = chars.Where(x => x == 'o').Count();

            return x == o;
        }

        public bool XOBest(string input) // best practice
        {
            input = input.ToLower();
            
            int x = input.Count(x => x == 'x');
            int o = input.Count(x => x == 'o');

            return x == o;
        }
    }
}
