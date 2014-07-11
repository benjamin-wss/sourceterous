using System;
using System.Globalization;

using Newtonsoft.Json;

namespace NoEncalsulation
{
    class Program
    {
        public class SomeKindaPoco
        {
            public int Id { get; set; }
            public string SomeKindaMessage { get; set; }
        }

        static void Main(string[] args)
        {
            var obj = new SomeKindaPoco()
            {
                Id = 1,
                SomeKindaMessage = "Skullduggery"
            };

            var jsonString = JsonConvert.SerializeObject(obj);

            Console.WriteLine("Now we got the POCO into a JSON string in ONE LINE !! Whee !!!!");
            Console.WriteLine(jsonString);

            var strongTypedJsonObject = JsonConvert.DeserializeObject<SomeKindaPoco>(jsonString);

            Console.WriteLine("Now we got the JSON string back into a POCO, WHEEEEE !!!!");
            Console.WriteLine("ID Property : " + strongTypedJsonObject.Id.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("SomeKindaMessageProperty : " + strongTypedJsonObject.SomeKindaMessage);

            Console.ReadLine();
        }
    }
}
