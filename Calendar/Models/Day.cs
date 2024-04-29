using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models
{
    internal class Day
    {
        public int number;
        public bool is_active;
        public string path_name;
        public List<Pivo> pivos;

        public Day()
        {
            pivos = new List<Pivo>();
            is_active = false;
        }

        public Day(int number)
        {
            this.number = number;
            pivos = new List<Pivo>();
            is_active = false;
        }

    }
}
