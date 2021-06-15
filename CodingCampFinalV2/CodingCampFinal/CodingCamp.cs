using System;
using System.Collections.Generic;
using System.Text;

namespace CodingCampFinal
{
    class CodingCamp
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Partisipant> Partisipants { get; set; }

        public CodingCamp()
        {
            Partisipants = new List<Partisipant>();
        }

        public CodingCamp(string id, string name, List<Partisipant> partisipants)
        {
            Id = id;
            Name = name;
            Partisipants = partisipants;
        }

        public void ShowData()
        {
            Console.WriteLine("ID        = "+Id);
            Console.WriteLine("  Nama Camp = "+Name);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----------Participant----------");
            Console.WriteLine("-------------------------------");
            if (Partisipants.Count > 0)
            {
                int i = 1;
                foreach (Partisipant p in Partisipants)
                {
                    Console.WriteLine("    "+i+".NIK  = " + p.Nik);
                    Console.WriteLine("      Nama = " + p.Nama);
                    i++;
                }
            }
            else
            {              
                Console.WriteLine("       No Data");
            }
            Console.WriteLine("-------------------------------");
        }
    }
}
