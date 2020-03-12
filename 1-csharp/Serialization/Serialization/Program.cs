using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // in .NET, for XML serialization, we have:
            //      -DataContractSerialization
            //      -XMLSerialization (old, non-generic)
            //  for JSON serialization, we have:
            //      -JSON.NET aka Newtonsoft JSON (third-party)
            //      -DataContractSerialization
            //      -System.Text.Json (brand new) (we'll use this one today)


            string filePath = "../../../data.json";

            List<Person> data = null;
            if (!File.Exists(filePath))
            {
                data = GetInitialData();

                string json = ConvertToJson(data);

                WriteToFile(json, filePath);
            }
            else
            {
                // read JSON from the file
                string json3 = ReadFromFile(filePath);
                // and deserialize it
                JsonSerializer.Deserialize<List<Person>>(json3);
            }
            ModifyPersons(data);

            string json2 = ConvertToJson(data);

            WriteToFile(json2, filePath);

        }

        private static string ReadFromFile(string filePath)
        {
            var sr = new StreamReader(filePath);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }

        private static void ModifyPersons(List<Person> data)
        {
            //do something to the persons to change that data
            foreach (var person in data)
            {
                person.Id++;
            }
        }

        private static void WriteToFile(string text, string path)
        {
            var file = new FileStream(path, FileMode.Create);
            byte[] data = Encoding.UTF8.GetBytes(text);

            file.Write(data);
            file.Close();
        }

        static string ConvertToJson(List<Person> data)
        {
            // uses System.Text.Json
            return JsonSerializer.Serialize(data);
        }

        static List<Person> GetInitialData()
        {
            var list = new List<Person>();
            var person1 = new Person();
            person1.Id = 1;
            person1.Name = "Nick";

            var person2 = new Person();
            person2.Id = 2;
            person2.Name = "Mark";
            person2.Children = new List<Person>
            {
                new Person {Id = 3, Name = "Ethan" },
                new Person {Id = 4, Name = "Hope" },
                new Person {Id = 5, Name = "Maya" }
            };

            list.Add(person1);
            list.Add(person2);
            return list;
        }
    }
}
