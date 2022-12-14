namespace FileIOOperations
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to File Operations!");
            Console.WriteLine("Enter 1-For File Operations");
            Console.WriteLine("Enter 2-For Stream Reader and Writer");
            Console.WriteLine("Enter 3-Peform Binary Serialize and Deserialize");
            Console.WriteLine("Enter 4-Peform XML Serialize and Deserialize");
            Console.WriteLine("Enter 5-Peform Json Serialization");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Enter 1-To check Whether File Exist!");
                    Console.WriteLine("Enter 2-To read all Lines of File");
                    Console.WriteLine("Enter 3-To read All Text in File");
                    Console.WriteLine("Enter 4-Create a Copy of another file");
                    Console.WriteLine("Enter 5-Delete a File");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            FileOperations.FileExists(@"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\File.txt");
                            break;
                        case 2:
                            FileOperations.ReadAllLine();
                            break;
                        case 3:
                            FileOperations.ReadAllText();
                            break;
                        case 4:
                            FileOperations.FileCopy();
                            break;
                        case 5:
                            FileOperations.DeleteFile();
                            break;

                    }
                    break;
                case 2:
                    Console.WriteLine("Enter 1-Read a file Using Stream Reader");
                    Console.WriteLine("Enter 2-Write to file using Stream Writer");
                    int streamchoice = Convert.ToInt32(Console.ReadLine());
                    switch (streamchoice)
                    {
                        case 1:
                            StreamReaderAndWriter.ReadFromStreamReader();
                            break;
                        case 2:
                            StreamReaderAndWriter.WriteUsingStreamWriter();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter 1-Binary Serialization");
                    Console.WriteLine("Enter 2-Binary DeSerialization");
                    int binarychoice = Convert.ToInt32(Console.ReadLine());
                    switch (binarychoice)
                    {
                        case 1:
                           BinaryOperations.BinarySerialization();
                            break;
                        case 2:
                            BinaryOperations.BinaryDeSerialization();
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter 1-XML Serialization");
                    Console.WriteLine("Enter 2-XML DeSerialization");
                    int xmlchoice = Convert.ToInt32(Console.ReadLine());
                    switch (xmlchoice)
                    {
                        case 1:
                            XMLOperations.SerializeXML();
                            break;
                        case 2:
                            XMLOperations.DeSerializeXML();
                            break;
                    }
                    break;
                case 5:
                    JSONSerialization.JSONSerialize();
                    break;
            }
        }
    }
}