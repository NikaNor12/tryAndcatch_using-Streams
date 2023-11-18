namespace ConsoleApp3
{
    internal class NumberFileHandler
    {
        public static void ProcessFile(string filePath)
        {
            int sum = 0;
            string outputFilePath = @"D:\" + Path.GetFileNameWithoutExtension(filePath) + "_2.txt";

            StreamReader reader = new StreamReader(filePath);

            StreamWriter writer2 = new StreamWriter(outputFilePath);

            int i = 1;
            string? line;

            try
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        sum += number;
                        line = $"{i++}.{line}";
                    }

                    else
                    {
                        line = $"{i++}.{line}";
                    }

                    writer2.WriteLine($"{line}");
                    Console.WriteLine($"{line}");
                }

                writer2.WriteLine($"Sum of numbers -> {sum}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine($"Sum of numbers {sum}");
            reader.Close();
            writer2.Close();
        }
    }
}
