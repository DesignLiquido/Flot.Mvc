using System;

namespace Flot.Mvc
{
    public class FlotGrid
    {
        public bool Show { get; set; }
        public bool AbovaData { get; set; }
        public String Color { get; set; }
        public String BackgroundColor { get; set; }
        public int? Margin { get; set; }
        public int? LabelMargin { get; set; }
        public int? AxisMargin { get; set; }
        public object Markings { get; set; }
        public object BorderWidth { get; set; }
        public object BorderColor { get; set; }
        public int? MinBorderMargin { get; set; }
        public bool Clickable { get; set; }
        public bool Hoverable { get; set; }
        public bool AutoHighlight { get; set; }
        public int? MouseActiveRadius { get; set; }
    }
}
