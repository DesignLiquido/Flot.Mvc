using Flot.Mvc.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flot.Mvc
{
    public class FlotSeries<TKey, TValue>
    {
        public String Color { get; set; }
        [JsonConverter(typeof(FlotDataDictionarySerializer))]
        public Dictionary<TKey, TValue> Data { get; set; }
        public String Label { get; set; }
        public object Lines { get; set; }
        public object Bars { get; set; }
        public object Points { get; set; }
        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public bool Clickable { get; set; }
        public bool Hoverable { get; set; }
        public int ShadowSize { get; set; }
        public String HighlightColor { get; set; }
    }
}
