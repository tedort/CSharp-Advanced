namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] linesFirstFile = File.ReadAllLines(firstInputFilePath);
            string[] linesSecondFile = File.ReadAllLines(secondInputFilePath);
            int smallerLength = linesSecondFile.Length;
            string[] biggerFileLines = linesFirstFile;
            if (linesFirstFile.Length < linesSecondFile.Length)
            {
                smallerLength = linesFirstFile.Length;
                biggerFileLines = linesSecondFile;
            }
            int difference = Math.Abs(linesFirstFile.Length - linesSecondFile.Length);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < smallerLength; i++)
                {
                    writer.WriteLine(linesFirstFile[i]);
                    writer.WriteLine(linesSecondFile[i]);
                }

                for (int i = smallerLength; i < biggerFileLines.Length; i++)
                {
                    writer.WriteLine(biggerFileLines[i]);
                }
            }
        }
    }
}
