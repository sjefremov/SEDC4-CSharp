using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToMacedonian
{
    static class Translator
    {
        static private Dictionary<string, List<string>> content;

        static Translator()
        {
            content = new Dictionary<string, List<string>>
            {
                { "apple", new List<string> { "jabolko" } },
                { "window", new List<string> { "prozorec" } },
                { "door", new List<string> { "vrata" } },
                { "chair", new List<string> { "stol" } },
                { "girl", new List<string> { "devojce", "devojka", "momice" } }
            };
        }
        public static void Add(string englishWord, List<string> macedonianWords)
        {
            if (content.ContainsKey(englishWord))
            {
                throw new Exception($"The word {englishWord} is already contained in our dictionary");
            }

            content.Add(englishWord, macedonianWords);
        }
        public static List<string> ToMacedonian(string englishWord)
        {
            if (!content.ContainsKey(englishWord))
            {
                throw new Exception($"The word {englishWord} is not contained in our dictionary");
            }
            return content[englishWord];
        }
    }
}
