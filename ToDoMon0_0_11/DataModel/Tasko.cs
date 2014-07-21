using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoMon0_0_11.DataModel
{
    public class Task
    {
        public int id { get; set; }
        public String Title { get; set; }
        public Double completionPercentage { get; set; }
        public int priority { get; set; }

        public int personMinutes { get; set; }
        public int startBy { get; set; }
        //CheckPoint deadline { get; set; }
        public int workPressure { get; set; }
        public int type { get; set; }
        public bool recurring { get; set; }
        public int imageType { get; set; }
        public String taskImagePath { get; set; }
        public bool openIdea { get; set; }




    }
}
