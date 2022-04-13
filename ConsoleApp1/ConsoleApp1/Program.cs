using Newtonsoft.Json;
using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




            //task1
            string path1 = @"C:\Users\emil code\Desktop\MyTaskFolder-1";
            
            ;
            using (StreamWriter sr = File.CreateText(path1 + @"\new.txt"))
            {
                sr.Write("Lorem ipsum dolor sit amet");
            }
            
          


            //task 2
            string path = @"C:\Users\emil code\Desktop\MyTaskFolder";

            Directory.CreateDirectory(path);
            var user1 = new User() { id = "user_1",age=15 ,Name="Mezahir",mail="falanfilan@gmail.com",Password="123456"};

            
            using (StreamWriter jsonWrite = File.CreateText(path+@"\myjson.json"))
            {
                var json = JsonConvert.SerializeObject(user1, Formatting.Indented);
                jsonWrite.Write(json);
            }
            using (StreamReader jsonRead = File.OpenText(path + @"\myjson.json"))
            {
                var data = JsonConvert.DeserializeObject( jsonRead.ReadToEnd());
                
                Console.WriteLine(data);
            }
        }
    }
}
