
namespace FileIOOperations
{
    public class StreamReaderAndWriter
    {
        public static string path = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\File.txt";

        public static void ReadFromStreamReader()
        {
            using (StreamReader str = File.OpenText(path))
            {
                string s = "";
                while ((s = str.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamWriter()
        {
            using (StreamWriter str = File.AppendText(path))
            {
                str.WriteLine("Using Stream Writer");
                str.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}

