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

                try
                {
                    WriteToFile(json, filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fatal error");
                    Console.WriteLine(ex.Message);
                    return;
                }
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

            try
            {
                WriteToFile(json2, filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fatal error");
                Console.WriteLine(ex.Message);
                return;
            }

        }

        private static string ReadFromFile(string filePath)
        {
            //using statement is the same as try/finally/not null/dispose, but way quicker to write and look at
            //using (var sr = new StreamReader(filePath))
            //{
            //    string text = sr.ReadToEnd();
            //    sr.Close();
            //    return text;
            //}

            // newer, using statement
            using var sr = new StreamReader(filePath);
            string text = sr.ReadToEnd();
            return text;
            // (sr is disposed when this block ends, when this method returns)
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

            // exception handling is important for good user experience
            // as well as data correctness etc

            // opening a file is something that definitely could go wrong
            // it's code that we expect to sometimes throw an exception
            // any code like that, we should put in a try {} block

            FileStream file = null;
            try
            {
                var file = new FileStream(path, FileMode.Create);
                byte[] data = Encoding.UTF8.GetBytes(text);

                file.Write(data);
            }
            //catch
            //{
            //    // we can catch ANY exception... this is bad practice
            //}
            catch (UnauthorizedAccessException ex)
            {
                // useful properties of the exception: 
                // Message, StackTrace, InnerException
                Console.WriteLine($"Access to file {path} is not allowed by the OS");
                Console.WriteLine(ex.Message);
                throw; //rethrows the exception to be caught again higher up in the call stack
            }
            finally
            {
                if (file != null)
                {
                    //file.Close();
                    file.Dispose();
                }
            }
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
