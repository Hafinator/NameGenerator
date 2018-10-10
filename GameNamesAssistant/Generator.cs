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
            //bool vowel = false;
            int withoutVowel = 0;
            while (name.Length < len)
            {
                letter = (char)random.Next(65, 90);
                if (name.Length == 0 || name[name.Length - 1] != letter)
                {
                    if (letter != 'A' && letter != 'E' && letter != 'I' && letter != 'O' && letter != 'U')
                    {
                        withoutVowel++;
                    }
                    else
                    {
                        withoutVowel = 0;
                    }
                    name += letter;

                    if (name.Length < len && withoutVowel >= 2)
                    {
                        switch (random.Next(5))
                        {
                            case 0:
                                name += 'A';
                                break;
                            case 1:
                                name += 'E';
                                break;
                            case 2:
                                name += 'I';
                                break;
                            case 3:
                                name += 'O';
                                break;
                            case 4:
                                name += 'U';
                                break;
                        }
                    }
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
            if (len >= 2)
            {
                int withoutVowel = 0;
                string name = "";
                char letter;
                while (name.Length < len)
                {
                    letter = (char)random.Next(65, 90);
                    if (name.Length == 0 || name[name.Length - 1] != letter)
                    {
                        if (letter != 'A' && letter != 'E' && letter != 'I' && letter != 'O' && letter != 'U')
                        {
                            withoutVowel++;
                        }
                        else
                        {
                            withoutVowel = 0;
                        }
                        name += letter;

                        if (name.Length < len && withoutVowel >= 2)
                        {
                            switch (random.Next(5))
                            {
                                case 0:
                                    name += 'A';
                                    break;
                                case 1:
                                    name += 'E';
                                    break;
                                case 2:
                                    name += 'I';
                                    break;
                                case 3:
                                    name += 'O';
                                    break;
                                case 4:
                                    name += 'U';
                                    break;
                            }
                        }
                    }
                }
                return name;
            }
            else
                return null;

        }
        /// <summary>
        /// Generates a random name from a given array of letters with the option to specify the length of the name. The length of the name is selected randomly between 3 and 15 letters.
        /// </summary>
        /// <param name="letters">The collection of at least 2 letters.</param>
        /// <param name="wordLen"> Optional length of the generated name. Default is random 3 - 15.</param>
        /// <returns>A randomly generated name. Null if incorrect parameters were specified.</returns>
        public static string GenerateRandomPlaceName(char[] letters, int wordLen = -1)
        {
            if (letters.Length >= 2)
            {
                if (wordLen > 2 || wordLen == -1)
                {
                    if (wordLen != -1)
                    {
                        int len = wordLen;
                        string name = "";
                        char letter;
                        int withoutVowel = 0;
                        List<char> vowels = new List<char>();

                        for (int i = 0; i < letters.Length; i++)
                        {
                            if ((letters[i] == 'a' || letters[i] == 'A') || (letters[i] == 'e' || letters[i] == 'E')||(letters[i] == 'i' || letters[i] == 'i') 
                                || (letters[i] == 'o' || letters[i] == 'O') || (letters[i] == 'u' || letters[i] == 'U'))
                            {
                                vowels.Add(letters[i]);
                            }
                        }

                        while (name.Length < len)
                        {
                            letter = letters[random.Next(letters.Length)];
                            if (name.Length == 0 || name[name.Length - 1] != letter)
                            {
                                if (!vowels.Contains(letter))
                                {
                                    withoutVowel++;
                                }
                                name += letter;
                                if (name.Length < len && withoutVowel >= 2)
                                {
                                    name += vowels[random.Next(vowels.Count)];
                                }
                            }
                        }
                        return name;
                    }
                    else
                    {
                        int len = random.Next(3, 16);
                        string name = "";
                        char letter;
                        int withoutVowel = 0;
                        List<char> vowls = new List<char>();

                        for (int i = 0; i < letters.Length; i++)
                        {
                            if ((letters[i] == 'a' || letters[i] == 'A') || (letters[i] == 'e' || letters[i] == 'E') || (letters[i] == 'i' || letters[i] == 'i')
                                || (letters[i] == 'o' || letters[i] == 'O') || (letters[i] == 'u' || letters[i] == 'U'))
                            {
                                vowls.Add(letters[i]);
                            }
                        }

                        while (name.Length < len)
                        {
                            letter = letters[random.Next(letters.Length)];
                            if (name.Length == 0 || name[name.Length - 1] != letter)
                            {
                                if (!vowls.Contains(letter))
                                {
                                    withoutVowel++;
                                }
                                name += letter;
                                if (name.Length < len && withoutVowel >= 2)
                                {
                                    name += vowls[random.Next(vowls.Count)];
                                }
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
