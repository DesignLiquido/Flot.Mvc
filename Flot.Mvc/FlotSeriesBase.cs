using Flot.Mvc.DataStructures;

namespace Flot.Mvc
{
    public abstract class FlotSeriesBase
    {
        public bool Show { get; set; } = true;
        public decimal LineWidth { get; set; }
        public bool Fill { get; set; } = true;
        public RGBA FillColor { get; set; } = new RGBA { PackedValue = 2556 };
    }
}