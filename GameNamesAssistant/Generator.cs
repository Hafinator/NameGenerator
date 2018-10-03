using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamesAssistant
{
    public static class Generator
    {
        static Random random = new Random();
        /// <summary>
        /// Generates a random 3 - 15 letters long uppercase name.
        /// </summary>
        /// <returns>A random name</returns>
        public static string GenerateRandomPlaceName()
        {
            int len = random.Next(3, 16);
            string name = "";
            char letter;
            while (name.Length < len)
            {
                letter = (char)random.Next(65, 90);
                if (name.Length == 0 || name[name.Length] != letter)
                {
                    name += letter;
                }
            }

            return name;
        }

        /// <summary>
        /// Generates a random uppercase name of a specific length.
        /// </summary>
        /// <param name="len">The length of a specific name</param>
        /// <returns>A random name</returns>
        public static string GenerateRandomPlaceName(int len)
        {
            string name = "";
            char letter;
            while (name.Length < len)
            {
                letter = (char)random.Next(65, 90);
                if (name.Length == 0 || name[name.Length] != letter)
                {
                    name += letter;
                }
            }
            return name;
        }
        /// <summary>
        /// Generates a random name from a given array of letters with the option to specify the length of the name. The length of the name is selected randomly between 3 and 15 letters.
        /// </summary>
        /// <param name="letters">The collection of at least 2 letters.</param>
        /// <param name="wordLen"> Optional length of the generated name. Default is random 3 - 15.</param>
        /// <returns>A randomly generated name. Null if incorrect parameters were specified.</returns>
        public static string GenerateRandomPlaceName(char[] letters, int wordLen = 0)
        {
            if (letters.Length > 2)
            {
                if (wordLen > 0)
                {
                    if (wordLen != 0)
                    {
                        int len = wordLen;
                        string name = "";
                        char letter;
                        while (name.Length < len)
                        {
                            letter = letters[random.Next(letters.Length)];
                            if (name.Length == 0 || name[name.Length] != letter)
                            {
                                name += letter;
                            }
                        }
                        return name;
                    }
                    else
                    {
                        int len = random.Next(3, 16);
                        string name = "";
                        char letter;
                        while (name.Length < len)
                        {
                            letter = letters[random.Next(letters.Length)];
                            if (name.Length == 0 || name[name.Length] != letter)
                            {
                                name += letter;
                            }
                        }
                        return name;
                    }
                }
                else
                    return null;

            }
            else
                return null;

        }
    }
}
