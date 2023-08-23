using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг шифра (используется русский алфавит)");
            int.TryParse(Console.ReadLine(), out var step);
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();


            List<int> numbers = new List<int>() { };
            List<char> letters = new List<char>() { };
            List<char> results = new List<char>() { };
            List<char> alphabet = new List<char>()
            {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
            };


            for (int i = 0; i < word.Length; i++)
            {
                letters.Add(word[i]);
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    if (letters[i] == alphabet[j])
                    {
                        numbers.Add(j + 1);
                    }
                }
            }




            Console.WriteLine("введите x для кодирования слова/введите y для декодирования слова");

            while (true) 
            {

                string data = Console.ReadLine();
                if (data == "x")
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        numbers[i] = numbers[i] + step;
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        for (int j = 0; j < 33; j++)
                        {
                            if (numbers[i] == j)
                            {
                                results.Add(alphabet[j - 1]);
                            }
                        }
                    }
                    for (int i = 0; i < word.Length; i++)
                    {
                        Console.Write(results[i]);
                    }
                }

            }


        }
    }
}
