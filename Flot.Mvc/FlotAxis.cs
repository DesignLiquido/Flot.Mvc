using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flot.Mvc
{
    public class FlotAxis
    {
        public bool Show { get; set; }
        public Flot.Mvc.Enums.FlotPosition Position { get; set; }
        public String Mode { get; set; }
        public String Timezone { get; set; }
        public String Color { get; set; }
        public String TickColor { get; set; }
        public String Font { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public int? AutoScaleImage { get; set; }
        public object Transform { get; set; }
        public object InverseTransform { get; set; }
        public int? Ticks { get; set; }
        public int? TickSize { get; set; }
        public int? MinTickSize { get; set; }
        public object TickFormatter { get; set; }
        public int? TickDecimals { get; set; }
        public int? LabelWidth { get; set; }
        public int? LabelHeight { get; set; }
        public bool ReserveSpace { get; set; }
        public int? TickLength { get; set; }
        public int? AlignTicksWithAxis { get; set; }
    }
}
