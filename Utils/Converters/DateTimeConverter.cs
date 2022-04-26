using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyApplication.Utils.Converters
{
    
        public class DateTimeConverter : JsonConverter<DateTime?>
        {
            public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.GetString() == "")
                    return null;
                return reader.GetDateTime();
            }

            public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
            {

                if (!value.HasValue)
                {
                    writer.WriteStringValue("");
                }
                else
                {
                    writer.WriteStringValue(value.Value);
                }
            }
        }
    }

