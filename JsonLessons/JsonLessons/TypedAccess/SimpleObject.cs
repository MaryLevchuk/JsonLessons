using System;
using System.Collections.Generic;

namespace JsonLessons
{
    public class SimpleObject
    {
        public string String { get; set; }

        public int Int { get; set; }

        public decimal Decimal { get; set; }

        public DateTime DateTime { get; set; }

        public bool Boolean { get; set; }

        public bool? NullableBoolean { get; set; } 

        public object Object { get; set; }

        public List<string> StringArray { get; set; }

        public SimpleObject NestedObject { get; set; }

        public decimal Money { get; set; }
    }
}