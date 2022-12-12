
using System.Xml.Serialization;

namespace FileIOOperations
{
    public class XMLOperations
    {
        public class XMLElements
        {
            public string Name;
            public DateTime dateTime;
        }
        public static void SerializeXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLElements));
            FileStream file = new FileStream(@"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\XMLFile.xml", FileMode.Create);
            XMLElements xMLElements = new XMLElements();
            xMLElements.Name = "Mahesh";
            DateTime dateTime = new DateTime(2021, 7, 26);
            xMLElements.dateTime = dateTime;
            serializer.Serialize(file, xMLElements);
        }
        public static void DeSerializeXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLElements));
            using (FileStream fileStream = new FileStream(@"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\FileIOOperations\FileIOOperations\XMLFile.xml", FileMode.Open))
            {
                XMLElements result = (XMLElements)serializer.Deserialize(fileStream);
                Console.WriteLine("-----After Deserialization------\n Name: {0} \t DateTime: {1}", result.Name, result.dateTime);
            }

        }

    }
}
