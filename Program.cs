using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 0;
            StringBuilder seed = new StringBuilder();
            int character = random.Next(1, 15);
            Dictionary<int, string> characters = new Dictionary<int, string>();
            characters.Add(1, "Isaac");
            characters.Add(2, "Magdalene");
            characters.Add(3, "Cain");
            characters.Add(4, "Judas");
            characters.Add(5, "???");
            characters.Add(6, "Eve");
            characters.Add(7, "Samson");
            characters.Add(8, "Azazel");
            characters.Add(9, "Lazarus");
            characters.Add(10, "Eden");
            characters.Add(11, "The Lost");
            characters.Add(12, "Lilith");
            characters.Add(13, "Keeper");
            characters.Add(14, "Apollyon");
            characters.Add(15, "The Forgotten");
            foreach (var item in characters)
            {
                if (item.Key==character)
                {
                    Console.WriteLine(item.Value);
                }
            }
            while (true)
            {
                int num = random.Next(1, 127);
                char word = (char)num;
                if (count!=8)
                {
                    if (char.IsDigit(word) || char.IsLetter(word))
                    {
                        if (word != 'I' && word != 'O' && word != '5' && word != 'U'&&word!='i'&&word!='u'&&word!='v'&& word != 'V')
                        {
                            seed.Append(word);
                            count++;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            string sed = seed.ToString().ToUpper();
            Console.WriteLine(sed);
        }
    }
}