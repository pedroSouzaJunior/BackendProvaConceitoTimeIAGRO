using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CatalogoDeLivros.Application.Utils
{
    public class ConversorIllustrator : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<string>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.String)
            {
                return new List<string> { token.Value<string>() };
            }
            else if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<string>>();
            }
            else
            {
                throw new JsonReaderException("Valor invalido para Illustrator");
            }
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
