using Calendar.Models;
using PRACT_LAB_5.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.VeiwModels
{
    internal class DayViewModel
    {
        public CommandHelper save;

        public static List<Pivo> pivos = Pivo.pivos;
        
        private void save_Click()
        {
            
        }

        public DayViewModel()
        {
            save = new CommandHelper(_ => save_Click());
        }
    }
}
