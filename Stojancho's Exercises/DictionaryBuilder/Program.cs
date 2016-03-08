using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FILE = @"data.json";
            var translations = new Dictionary<string, List<string>>();
            //1. Read Data
            string data = string.Empty;
            if (File.Exists(FILE))
            {
                data = File.ReadAllText(FILE);
            }

            //1.a. Does previous data exist?
            if (data.Length > 0)
            {
                translations = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(data);
            }



            //1.a.1 Prev data exist => Load Data

            //1.a.1.a Read text from file
            //1.a.1.b deserialize to dictionary
            //1.a.2 Prev data does not exist => empty data

            

            while (true)
            {
                Console.Write("Enter word (in english) or 0 for finish: ");
                var englishWord = Console.ReadLine();
                if (englishWord.Equals("0"))
                {
                    break;
                }

                if (translations.ContainsKey(englishWord))
                {
                    Console.WriteLine($"{englishWord} translates to {string.Join(", ",translations[englishWord])}");
                }
                else
                {
                    Console.Write($"Enter translations for {englishWord} divided with space: ");
                    var macedonianWords = Console.ReadLine().Split(new[] { ' ' });
                    translations.Add(englishWord, macedonianWords.ToList<string>());
                }
            }

            //2. Add new data
            //2.a. Input new word
            //2.b. Input new translation
            //2.c. Add to existing data
            File.WriteAllText(FILE, JsonConvert.SerializeObject(translations));
            //3. Write Data
            //3.a Write to file
            //3.a.1 Serialize to text
            //3.a.2 write text to file
        }
    }
}
