using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flot.Mvc.JsonConverters
{
    internal class FlotDataDictionarySerializer : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.GetInterfaces().Any(i => i.Name == "IDictionary");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Data should be written as an array of arrays, according to Flot specification. 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value">Should be a dictionary.</param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // I'm not sure if this is needed.
            if (!(value is IDictionary)) throw new Exception("Value is not a dictionary.");

            foreach (dynamic teste in (IEnumerable)value)
            {
                writer.WriteStartArray();
                serializer.Serialize(writer, teste.Key);
                serializer.Serialize(writer, teste.Value);
                writer.WriteEndArray();
                writer.WriteRaw(", ");
            }
        }
    }
}
