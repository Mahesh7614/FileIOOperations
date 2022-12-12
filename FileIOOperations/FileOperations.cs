
namespace FileIOOperations
{
    public class FileOperations
    {
        public static String path = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\File.txt";

        public static void FileExists(string path)
        {
            Console.WriteLine("-----Check whether a File Exist-----");
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists!\n");

            }
            else
            {
                Console.WriteLine("File Does Not Exist!");
            }
        }
        public static void ReadAllLine()
        {
            Console.WriteLine("-----Read each line from file and store in List-----\n");
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1] + "\n");


        }
        public static void ReadAllText()
        {
            Console.WriteLine("-----Read all Text from File-----\n");
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines + "\n");

        }
        public static void FileCopy()
        {
            Console.WriteLine("-----Copy file from One file to another-----\n");
            string copyPath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\CopiedFile.txt";
            File.Copy(path, copyPath);
            string lines = File.ReadAllText(copyPath);
            Console.WriteLine(lines + "\n");

        }
        public static void DeleteFile()
        {
            Console.WriteLine("Delete a File\n");
            string copyPath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\CopiedFile.txt";
            File.Delete(copyPath);
            FileExists(copyPath);
        }

    }
}

