using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace AnalyzingLeaksWithASimpleEventsEx1
{
    public delegate string MyDelegate(string str);

    class SimpleEventClass
    {
        public int ID { get; set; }

        public event MyDelegate SimpleEvent;

        public SimpleEventClass()
        {
            SimpleEvent += new MyDelegate(PrintText);
        }
        public string PrintText(string text)
        {
            return text;
        }

        static void Main(string[] args)
        {
            IDictionary<int, SimpleEventClass> col = new Dictionary<int, SimpleEventClass>();
            for (int objectNo = 0; objectNo < 500000; objectNo++)
            {
                col[objectNo] = new SimpleEventClass { ID = objectNo };
                string result = col[objectNo].SimpleEvent("Raising an event ");
                Console.WriteLine(objectNo);
            }
            Console.ReadKey();
        }
    }
}

