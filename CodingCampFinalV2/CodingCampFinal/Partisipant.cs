using System;
using System.Collections.Generic;
using System.Text;

namespace CodingCampFinal
{
    class Partisipant
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public CodingCamp CodingCamp { get; set; }

        public Partisipant()
        {
            
        }

        public Partisipant(string nik, string nama, CodingCamp codingCamp)
        {
            Nik = nik;
            Nama = nama;
            CodingCamp = codingCamp;
        }
    }
}
