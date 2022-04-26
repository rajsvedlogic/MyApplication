using MyApplication.Core;
using Newtonsoft.Json;
using System;


namespace MyApplication.Utils.Converters
{
    public class GuidToModel<T> : JsonConverter<T>
    {

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {

            if (reader.TokenType == JsonToken.Null || String.IsNullOrEmpty(reader.Value.ToString()) || string.IsNullOrWhiteSpace(reader.Value.ToString()))
            {
                return default;
            }

            //if(objectType is Guid)
            //{
            //    return default;
            //}

            if (reader.TokenType == JsonToken.String && typeof(T).IsSubclassOf(typeof(Base.Model)))
            {

                T instance = (T)Activator.CreateInstance(typeof(T));
                (instance as Base.Model).id = new Guid(reader.Value.ToString());

                return instance;
            }

            return default;

        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            try
            {
                //writer.WriteValue((value as Base.Model).id);
                writer.WriteRawValue(JsonConvert.SerializeObject(value, Formatting.Indented,Constants.SerializerSettings));
            }
            catch (Exception e)
            {
                Console.WriteLine("Here");
            }
        }
    }

}
