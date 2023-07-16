using Serilog.Core;
using Serilog.Events;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Onron.Serilog.DestructPolicy
{
    public class DestructWithSystemTextJson : IDestructuringPolicy
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        public bool TryDestructure(object value, ILogEventPropertyValueFactory propertyValueFactory, out LogEventPropertyValue result)
        {
            result = new ScalarValue(JsonSerializer.Serialize(value, options));

            return true;
        }
    }
}
