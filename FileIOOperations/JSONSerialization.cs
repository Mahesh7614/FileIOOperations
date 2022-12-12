
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace FileIOOperations
{
    public class JSONSerialization
    {
        public static void JSONSerialize()
        {
            string filePath = "C:\\Users\\Mahesh\\OneDrive\\Desktop\\Assignments\\RFP .Net Assignment\\FileIOOperations\\FileIOOperations\\JSONFile.json";
            BlogSites blog = new BlogSites()
            {
                Name = "Mahesh",
                Description = "Welcome to Universe"
            };
            string jsonData = JsonConvert.SerializeObject(blog);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine(jsonData);
        }
    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
