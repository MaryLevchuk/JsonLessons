using System;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonLessons
{
    public class TypedAccessTests
    {

        public TypedAccessTests()
        {
            this.SimpleObject = new SimpleObject
            {
                Boolean = true,
                DateTime = DateTime.Now,
                Decimal = 10,
                Int = 1,
                NestedObject = new SimpleObject(),
                NullableBoolean = true,
                Object = new SimpleObject(),
                String = "string field",
                StringArray = {"string1", "string2", "string3"}
            };

            SimpleObject.Money = 1.0M;
        }

        public SimpleObject SimpleObject { get; set; }

        [Test]
        public void FirstTest()
        {
            string jsonString = JsonConvert.SerializeObject(SimpleObject);
            Console.WriteLine("jsonString = {0}", jsonString);
        }
    }
}
