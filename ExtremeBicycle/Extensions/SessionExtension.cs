using ExtremeBicycle.Models.Entities;
using Newtonsoft.Json;

namespace ExtremeBicycle.Extensions
{
    public static class SessionExtension
    {

        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            //stringify the object
            var stringValue = JsonConvert.SerializeObject(value);
            session.SetString(key, stringValue);

        }
        //T is generic
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        public static void SetCart(this ISession session, List<Product> value)
        {
            session.SetObjectAsJson("cart", value);
        }

        public static List<Product> GetCart(this ISession session)
        {
            var temp = session.GetObjectFromJson<List<Product>>("cart");

            if (temp == null)
            {
                temp = new List<Product>();
            }
            return temp;
        }

    }
}

