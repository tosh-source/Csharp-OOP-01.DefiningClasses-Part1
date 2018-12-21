using HomeworkMobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class TestApp
    {
        static void Main(string[] args)
        {
            var gsm = new GSM("S 7 Edge", "Samsung", "500$", owner: "Frank");
            Console.WriteLine(gsm.ToString());
        }
    }
}
