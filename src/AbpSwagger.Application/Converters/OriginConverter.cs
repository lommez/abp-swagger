using AbpSwagger.Enums;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AbpSwagger.Converters
{
    public class OriginConverter : JsonConverter<Origin>
    {
        public override Origin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.String)
            {
                throw new JsonException();
            }

            if (Enum.TryParse(reader.GetString(), ignoreCase: true, out Origin enumValue))
            {
                return enumValue;
            }
            else
            {
                throw new JsonException();
            }
        }

        public override void Write(Utf8JsonWriter writer, Origin value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}