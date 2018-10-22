using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    static class Translite
    {
        public static string Transliterator(this string[] args)
        {
            if (args.Length==0) //check on empty input line
            {
                Console.WriteLine("string is empty");
                Console.ReadKey();
            }
            StringBuilder EnterString = new StringBuilder(args[0].ToLower());
            char str = EnterString[0]; //check language of input string
            if (str >= 'а') //if input string - english
            {               
                EnterString.Replace("а", "a"); //Change russian letter to english
                EnterString.Replace("б", "b");
                EnterString.Replace("в", "v");
                EnterString.Replace("г", "g");
                EnterString.Replace("д", "d");
                EnterString.Replace("е", "e");
                EnterString.Replace("ё", "yo");
                EnterString.Replace("ж", "zh");
                EnterString.Replace("з", "z");
                EnterString.Replace("и", "i");
                EnterString.Replace("й", "y");
                EnterString.Replace("к", "k");
                EnterString.Replace("л", "l");
                EnterString.Replace("м", "m");
                EnterString.Replace("н", "n");
                EnterString.Replace("о", "o");
                EnterString.Replace("п", "p");
                EnterString.Replace("р", "r");
                EnterString.Replace("с", "s");
                EnterString.Replace("т", "t");
                EnterString.Replace("у", "u");
                EnterString.Replace("ф", "f");
                EnterString.Replace("х", "kh");
                EnterString.Replace("ц", "ts");
                EnterString.Replace("ч", "ch");
                EnterString.Replace("ш", "sh");
                EnterString.Replace("щ", "sch");
                EnterString.Replace("ъ", string.Empty);
                EnterString.Replace("ы", "y");
                EnterString.Replace("ь", string.Empty);
                EnterString.Replace("э", "e");
                EnterString.Replace("ю", "yu");
                EnterString.Replace("я", "yа");

            }

            else //if input string - russian
            {
                EnterString.Replace("sch", "щ"); //change english letters to russian
                EnterString.Replace("sh", "ш");
                EnterString.Replace("yo", "ё");
                EnterString.Replace("yu", "ю");
                EnterString.Replace("ya", "я");
                EnterString.Replace("kh", "х");
                EnterString.Replace("ts", "ц");
                EnterString.Replace("ch", "ч");
                EnterString.Replace("zh", "ж");
                EnterString.Replace("a", "а");
                EnterString.Replace("b", "б");
                EnterString.Replace("v", "в");
                EnterString.Replace("g", "г");
                EnterString.Replace("d", "д");
                EnterString.Replace("e", "е");
                EnterString.Replace("z", "з");
                EnterString.Replace("i", "и");
                EnterString.Replace("y", "й");
                EnterString.Replace("k", "к");
                EnterString.Replace("l", "л");
                EnterString.Replace("m", "м");
                EnterString.Replace("n", "н");
                EnterString.Replace("o", "о");
                EnterString.Replace("p", "п");
                EnterString.Replace("r", "р");
                EnterString.Replace("s", "с");
                EnterString.Replace("t", "т");
                EnterString.Replace("u", "у");
                EnterString.Replace("f", "ф");
            }
            return EnterString.ToString();  //Return changed string
        }
    }
}



