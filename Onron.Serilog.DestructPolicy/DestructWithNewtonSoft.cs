using Newtonsoft.Json;
using Serilog.Core;
using Serilog.Events;
using System;

namespace Onron.Serilog.DestructPolicy
{
    public class DestructWithNewtonSoft : IDestructuringPolicy
    {
        public bool TryDestructure(object value, ILogEventPropertyValueFactory propertyValueFactory, out LogEventPropertyValue result)
        {
            result = new ScalarValue(JsonConvert.SerializeObject(value));
            return true;
        }
    }
}
