using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaLin_20240916
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Spaces { get; set; }
        public bool Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age => (int)(DateTime.Now - BirthDate).TotalDays/365;

        public override string ToString()
        {
            return $"{Name} ({Age} years old {Spaces})";
        }
    }
}
