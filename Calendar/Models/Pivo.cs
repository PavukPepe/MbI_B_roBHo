using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models
{
    internal class Pivo
    {
        public int weight;
        string name;
        string path_name;
        Pivo(int weight, string name, string path_name) 
        {
            this.weight = weight;
            this.name = name;
            this.path_name = path_name;
        }
        public Pivo kozel = new Pivo(1, "Козел", "../Sources/unnamed.png");
        public Pivo shpaten = new Pivo(2, "Шпатен", "../Sources/unnamed.png");
        public Pivo baltica_9 = new Pivo(5, "Балтика 9", "../Sources/unnamed.png");
        public Pivo starii_from_bochonock = new Pivo(1, "Старый мельник из боченка", "../Sources/unnamed.png");
        public Pivo esse = new Pivo(4, "Ессе", "../Sources/unnamed.png");
    }

   

}
