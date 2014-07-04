using Newtonsoft.Json;

namespace ExtensionMethodEncapsulation
{
    public static class JsonExtensions
    {
        /// <summary>
        /// Method to encapsulate how you serialize your JSON object.
        /// </summary>
        /// <typeparam name="T">The type of the object/POCO you wish to convert to JSON.</typeparam>
        /// <param name="obj">The JSON object.</param>
        /// <returns></returns>
        public static string SerializeAsJsonString<T>(this T obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);

            return jsonString;
        }

        /// <summary>
        /// Method to encapsulate how you deserialize your JSON string.
        /// </summary>
        /// <typeparam name="T">The strong typed object represantation of your JSON string/object</typeparam>
        /// <param name="json">The string representing your JSON object.</param>
        /// <returns></returns>
        public static T DeserializeJsonString<T>(this string json)
        {
            var deserializedObject = JsonConvert.DeserializeObject<T>(json);

            return deserializedObject;
        }
    }
}
