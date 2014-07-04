using System;
using System.Globalization;

namespace ExtensionMethodEncapsulation
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

            var jsonString = obj.SerializeAsJsonString();

            Console.WriteLine("Now we got the POCO into a JSON string in ONE LINE via our brand spankin new extension method. !! Whee !!!!");
            Console.WriteLine(jsonString);

            var strongTypedJsonObject = jsonString.DeserializeJsonString<SomeKindaPoco>();

            Console.WriteLine("Now we got the JSON string back into a POCO via our extension method., WHEEEEE !!!!");
            Console.WriteLine("ID Property : " + strongTypedJsonObject.Id.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("SomeKindaMessageProperty : " + strongTypedJsonObject.SomeKindaMessage);

            Console.ReadLine();
        }
    }
}
