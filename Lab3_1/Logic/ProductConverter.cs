using Lab3.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Lab3.Logic
{
    public class ProductConverter : JsonConverter<Product>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(Product).IsAssignableFrom(typeToConvert);
        }

        public override Product Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Expected StartObject token");
            }

            int id = 0;
            string name = null;
            decimal price = 0;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException("Expected PropertyName token");
                }

                string propertyName = reader.GetString();

                if (!reader.Read())
                {
                    throw new JsonException("Unexpected end of JSON while reading property value");
                }

                switch (propertyName)
                {
                    case "Id":
                        id = reader.GetInt32();
                        break;
                    case "Name":
                        name = reader.GetString();
                        break;
                    case "Price":
                        price = reader.GetDecimal();
                        break;
                    default:
                        throw new JsonException($"Unexpected property '{propertyName}'");
                }
            }

            return new Product { ProductId = id, ProductName = name, UnitPrice = price };
        }

        public override void Write(Utf8JsonWriter writer, Product value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("ProductId", Convert.ToString(value.ProductId));
            writer.WriteString("ProductName", value.ProductName);
            writer.WriteNumber("UnitPrice", (decimal)value.UnitPrice);
            writer.WriteEndObject();
        }
    }


}
