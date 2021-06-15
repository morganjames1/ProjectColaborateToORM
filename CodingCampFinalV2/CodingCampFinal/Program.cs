using System;
using System.Collections.Generic;

namespace CodingCampFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CodingCamp> codingCamps = new List<CodingCamp>()
            {
                new CodingCamp { Id = "MCC-REG-45-NET", Name = "Coding Camp 45" },
                new CodingCamp { Id = "MCC-REG-46-NET", Name = "Coding Camp 46" },
                new CodingCamp { Id = "MCC-REG-47-JAVA", Name = "Coding Camp 47" },
                new CodingCamp { Id = "MCC-REG-48-JAVA", Name = "Coding Camp 48" }
            };


            Partisipant Mahendra = new Partisipant();
            Mahendra.Nik = "1700";
            Mahendra.Nama = "Mahendra";
            Mahendra.CodingCamp = codingCamps[0];

            Partisipant Morgan = new Partisipant();
            Morgan.Nik = "1701";
            Morgan.Nama = "Morgan";
            Morgan.CodingCamp = codingCamps[0];

            Partisipant Budi = new Partisipant();
            Budi.Nik = "1702";
            Budi.Nama = "Budi";
            Budi.CodingCamp = codingCamps[0];

            Partisipant Mona = new Partisipant();
            Mona.Nik = "1703";
            Mona.Nama = "Mona";
            Mona.CodingCamp = codingCamps[3];

            codingCamps[0].Partisipants.Add(Mahendra);
            codingCamps[0].Partisipants.Add(Morgan);
            codingCamps[0].Partisipants.Add(Budi);
            codingCamps[3].Partisipants.Add(Mona);

        one:
            Console.Clear();
            Console.WriteLine("===Menu===");
            Console.WriteLine("1. Add Coding Camp");
            Console.WriteLine("2. Delete Coding Camp");
            Console.WriteLine("3. Edit Coding Camp");
            Console.WriteLine("4. Show Coding Camp");
            Console.WriteLine("5. Add Participant");
            Console.WriteLine("6. Exit");
            Console.WriteLine("");
            Console.Write("Option (1 - 5): "); int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    AddCodingCamp(codingCamps);
                    goto one;
                case 2:
                    DeleteCodingCamp(codingCamps);
                    goto one;
                case 3:
                    EditCodingCamp(codingCamps);
                    goto one;
                case 4:
                    ShowAllData(codingCamps);
                    goto one;
                case 5:
                    AddParticipant(codingCamps);
                    goto one;
                case 6:
                    TotalParticipant(codingCamps);
                    goto one;
                case 7:
                    Exit();
                    break;
                default:
                    Warning();
                    goto one;
            }
        }

        private static void AddCodingCamp(List<CodingCamp> codingCamps)
        {
        xy:
            try
            {
                Console.Clear();
                Console.Write("ID               = "); string idCodingCamp = Convert.ToString(Console.ReadLine());
                Console.Write("Name Coding Camp = "); string nameCodingCamp = Convert.ToString(Console.ReadLine());
                codingCamps.Add(new CodingCamp { Id = idCodingCamp, Name = nameCodingCamp });
            }
            catch (Exception)
            {

                Console.WriteLine("Masukan Data dengan Benar !");
                goto xy;
            }
        }

        private static void DeleteCodingCamp(List<CodingCamp> codingCamps)
        {
            Console.Clear();
            for (int i = 0; i < codingCamps.Count; i++)
            {
                Console.WriteLine(i + 1 + ".ID               = " + codingCamps[i].Id);
                Console.WriteLine("  Name Coding Camp = " + codingCamps[i].Name);
            }

        x:
            try
            {
                Console.Write("Pilih Data : "); int choice = Convert.ToInt32(Console.ReadLine());
                codingCamps.RemoveAt(choice - 1);

            }
            catch (Exception)
            {

                Console.WriteLine("Index Tidak tersedia !");
                Console.ReadLine();
                goto x;

            }
        }

        private static void EditCodingCamp(List<CodingCamp> codingCamps)
        {
            Console.Clear();
            for (int i = 0; i < codingCamps.Count; i++)
            {
                Console.WriteLine(i + 1 + ".ID               = " + codingCamps[i].Id);
                Console.WriteLine("  Name Coding Camp = " + codingCamps[i].Name);
            }

        y:
            try
            {
                Console.Write("Pilih Data : "); int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ID               = " + codingCamps[choice - 1].Id);
                Console.Write("Name Coding Camp = "); codingCamps[choice - 1].Name = Convert.ToString(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Index Tidak tersedia !");
                Console.ReadLine();
                goto y;
            }
        }

        private static void ShowAllData(List<CodingCamp> codingCamps)
        {
            Console.Clear();
            int i = 1;
            foreach (var item in codingCamps)
            {
                Console.Write(i+"."); item.ShowData();
                i++;
            }
            Console.ReadKey();
        }

        private static void AddParticipant(List<CodingCamp> codingCamps)
        {
            Console.Clear();
            for (int i = 0; i < codingCamps.Count; i++)
            {
                Console.WriteLine(i + 1 + ".ID               = " + codingCamps[i].Id);
                Console.WriteLine("  Name Coding Camp = " + codingCamps[i].Name);
            }

        z:
            try
            {
                Console.Write("Pilih Data : "); int noCodingCamp = Convert.ToInt32(Console.ReadLine());
                int indexCodingCamp = noCodingCamp - 1;
                Console.Write("Nik    = "); string nik = Convert.ToString(Console.ReadLine());
                Console.Write("Nama   = "); string nama = Convert.ToString(Console.ReadLine());
                codingCamps[indexCodingCamp].Partisipants.Add(new Partisipant { Nik = nik, Nama = nama });
            }
            catch (Exception)
            {
                Console.WriteLine("Index Tidak tersedia !");
                Console.ReadLine();
                goto z;
            }
        }


        static void TotalParticipant(List<CodingCamp> codingCamps)
        {
            int j = 1;
            foreach (CodingCamp item in codingCamps)
            {

                Console.WriteLine($"{j}. Id : {item.Id}");
                Console.WriteLine($"Name    : {item.Name}");
                j++;
            }

            Console.Write("Input Index CodingCamp : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            int pilih2 = pilih - 1;
            Console.Write($"Jumlah Partisipan : {codingCamps[pilih2].Partisipants.Count}");
            Console.ReadKey();
            Console.WriteLine();
        }

        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Terimakasi :)");
            Console.ReadKey();
        }

        private static void Warning()
        {
            Console.Clear();
            Console.WriteLine("No Choice!");
            Console.ReadKey();
        }
    }
}
