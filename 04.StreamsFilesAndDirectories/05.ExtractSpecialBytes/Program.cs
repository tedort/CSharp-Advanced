namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] bytesToSearch = File.ReadAllLines(bytesFilePath)
                                        .Select(line => Convert.ToByte(line))
                                        .ToArray();
            byte[] inputBytes = File.ReadAllBytes(binaryFilePath);

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                foreach (byte b in inputBytes)
                {
                    if (bytesToSearch.Contains(b))
                    {
                        writer.WriteLine(b);
                    }
                }
            }
        }
    }
}
