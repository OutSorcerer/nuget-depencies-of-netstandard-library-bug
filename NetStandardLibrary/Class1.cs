using System;
using Newtonsoft.Json;

namespace NetStandardLibrary
{
    public class Class1
    {
        public string Text { get; set; }

        public Class1()
        {
            Text = JsonConvert.SerializeObject(new[] { "a", "b", "c" });
        }
    }
}
