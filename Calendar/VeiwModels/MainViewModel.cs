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
        public DateTime current_date = DateTime.Now;

        public CommandHelper prev;
        public CommandHelper next;
        public CommandHelper claer;
        public DayViewModel() 
        {
            List<Day> days = new List<Day>();
            for (int i = 1; i <= DateTime.DaysInMonth(current_date.Year, current_date.Month); i++)
            {
                Day day = new Day();
                days.Add(day);
            }
            prev = new CommandHelper(_ => prev_Click());
            next = new CommandHelper(_ => next_Click());
            claer = new CommandHelper(_ => clear_Click());
        }

        private void clear_Click()
        {
            
        }

        private void prev_Click()
        {
            current_date = current_date.AddDays(-1);
        }

        private void next_Click() 
        {
            current_date = current_date.AddDays(1);
        }




    }
}
