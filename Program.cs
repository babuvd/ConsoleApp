using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace conleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder dr= new StringBuilder();
            List<FileDetails> details =new  List<FileDetails>();

            long id=0;
            foreach(var dir in Directory.GetDirectories("/home/duraiv"))
            {

                details.Add(new FileDetails{
                     Id =id,
                     FileName=dir
                });

            }

            string jsonstring= JsonSerializer.Serialize(details);



            System.IO.File.WriteAllText("/home/duraiv/test.json",jsonstring);


        }
    }
}
