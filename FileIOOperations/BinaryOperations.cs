using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace FileIOOperations
{

    [Serializable]
    public class Demo
    {
        public string name { get; set; } = "Mahesh";
        public string age { get; set; } = "15";
    }
    public class BinaryOperations
    {
        public static void BinarySerialization()
        {
            Demo user = new Demo();
            FileStream file = new FileStream(@"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\BinaryFile.txt", FileMode.Create);
            BinaryFormatter serialise = new BinaryFormatter();
            serialise.Serialize(file, user);
            file.Close();
            Console.WriteLine("Successfully Serialized!");
        }
        public static void BinaryDeSerialization()
        {
            Demo person = null;
            FileStream file = new FileStream(@"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\BinaryFile.txt", FileMode.Open);
            BinaryFormatter deserialise = new BinaryFormatter();
            person = (Demo)deserialise.Deserialize(file);
            file.Close();
            Console.WriteLine("----- After Binary Deserialization -----");
            Console.WriteLine("Name: {0} \t Age: {1}", person.name, person.age);
        }
    }
}
