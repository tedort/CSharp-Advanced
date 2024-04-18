using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string wordsToSeparate = File.ReadAllText(wordsFilePath);
            string[] wordsToFind = wordsToSeparate.Split();
            Dictionary<string, int> counter = new Dictionary<string, int>();

            string[] text = File.ReadAllLines(textFilePath);
            for (int i = 0; i < text.Length; i++)
            {
                string[] splittedRow = text[i].Split(" ", StringSplitOptions.TrimEntries);
                for (int j = 0; j < splittedRow.Length; j++)
                {
                    for (int n = 0; n < wordsToFind.Length; n++)
                    {
                        Regex wordToMatch = new Regex($@"\b({wordsToFind[n]})\b");
                        if (wordToMatch.IsMatch(splittedRow[j].ToLower()))
                        {
                            if (!counter.ContainsKey(wordsToFind[n]))
                            {
                                counter.Add(wordsToFind[n], 0);
                            }
                            counter[wordsToFind[n]]++;
                        }
                    }
                }
            }

            counter = counter
                                .OrderByDescending(counter => counter.Value)
                                .ToDictionary(counter => counter.Key, counter => counter.Value);

            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                foreach (var item in counter)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
