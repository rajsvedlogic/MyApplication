using Newtonsoft.Json;

namespace MyApplication.Core
{
    public static class Constants
    {
        public static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            FloatFormatHandling = FloatFormatHandling.DefaultValue
        };
    }
}
