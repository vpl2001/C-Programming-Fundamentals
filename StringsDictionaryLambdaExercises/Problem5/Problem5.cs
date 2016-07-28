using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Problem5
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine();
        var phonebook = new SortedDictionary<string, string>();
        var text = new List<string>();

        while (input!="END")
        {
            text.Add(input);
            input = Console.ReadLine();
        }

        foreach (var i in text)
        {
            var info = Regex.Split(i, @"\s+");
            var command = info[0];
            var name = "";
            var phone = "";

            if (command=="A")
            {
                name = info[1];
                phone = info[2];
                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = phone;
                }
                else
                {
                    phonebook.Add(name, phone);
                }
               
            }
            else if (command == "ListAll")
            {
                foreach (var item in phonebook)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
            }
            else
            {
                name = info[1];
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", name);
                }
            }

        }     
        }
    }