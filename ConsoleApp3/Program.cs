namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {       
            string FilePath = @"D:\viri.txt";
            StreamWriter writer = new StreamWriter(FilePath);

            writer.WriteLine("Nika");
            writer.WriteLine("Elene");
            writer.WriteLine("Gio");
            writer.WriteLine("Gela");
            writer.WriteLine("Dgnachvi");
            writer.WriteLine(52);
            writer.WriteLine(34);
            writer.WriteLine(1);
            writer.WriteLine(86);
            writer.WriteLine(33);
            writer.Close();


            //  helper მეთოდის გამოძახება NumberFileHandler-დან.
            NumberFileHandler.ProcessFile(FilePath);
        }
    }
}
