using ItAcademy.HomeWorkNumThree.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumThree.Halper
{
    public class Helper
    {
        public static void Delete (int id)
        {
            string writePath = @"C:\Users\yurqaa\source\repos\ItAcademy.HomeWorkNumThree\users.txt";
            var obj = JsonConvert.DeserializeObject<Item>
                (File.ReadAllText(writePath));
            List<User> UL = new List<User>();
            foreach (var item in obj.items)
            {
                UL.Add(item);
            }
            UL.RemoveAt(id);
        }
        public static void AddToJson (User user)
        {
            Item item = new Item();
            item.items.Add(new User()
            {
                Id = 0,
                FirstName = "Artsiom",
                LastName = "Vishenvskii",
                UserTitle = Title.Mr,
                Country = "USA",
                Sity = "California",
                Email = "Artsiom@gmail.com",
                Phone = 88005553555
            }) ;

            item.items.Add(new User()
            {
                Id = 1,
                FirstName = "Yury",
                LastName = "Petruchenia",
                UserTitle = Title.Mr,
                Country = "USA",
                Sity = "California",
                Email = "Yury@gmail.com",
                Phone = 90934593490
            });

            item.items.Add(new User()
            {
                Id = 2,
                FirstName = "Mary",
                LastName = "Maryia",
                UserTitle = Title.Mrs,
                Country = "USA",
                Sity = "California",
                Email = "Mary@gmail.com",
                Phone = 904252354
            });

            user.Id = item.items.Count();
            item.items.Add(user);

            string json = JsonConvert.SerializeObject(item, Formatting.Indented);

            string writePath = @"C:\Users\yurqaa\source\repos\ItAcademy.HomeWorkNumThree\users.txt";

            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(json);
            }
        }

        public static object GetFromJson ()
        {
            string writePath = @"C:\Users\yurqaa\source\repos\ItAcademy.HomeWorkNumThree\users.txt";
            var obj = JsonConvert.DeserializeObject<Item>
                (File.ReadAllText(writePath));
            List<User> UL = new List<User>();
            foreach (var item in obj.items)
            {
                UL.Add(item);
            }
            return UL;
        }
    }
}