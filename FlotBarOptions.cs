using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flot.Mvc
{
    public class FlotBarOptions
    {
        public bool Show { get; set; }
        public int LineWidth { get; set; }
        public int BarWidth { get; set; }
        public bool Fill { get; set; }
        public String FillColor { get; set; }
        public Flot.Mvc.Enums.FlotAlign Align { get; set; }
        public bool Horizontal { get; set; }
        public bool Zero { get; set; }
    }
}
