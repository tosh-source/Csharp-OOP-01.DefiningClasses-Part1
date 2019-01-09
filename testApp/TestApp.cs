using HomeworkMobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testApp
{
    class TestApp
    {
        static void Main(string[] args)
        {
            //First GSM
            var gsm = new GSM("S 7 Edge", "Samsung", "500$", owner: "Frank", batterySpec: new Battery(), displaySpec: new Display());
            Console.WriteLine("First GSM\n" + gsm.ToString());

            //Second GSM
            var gsm2 = new GSM("S 7 Edge", "Samsung", "500$", owner: "Frank", 
                                batterySpec: new Battery { BatteryModel = "Samsung 3600mAh battery", HoursIdle = 96, HoursTalk = 27, BatteryType = BatteryType.LiIon }, 
                                displaySpec: new Display());
            Console.WriteLine("\nSecond GSM\n" + gsm2.ToString());

            //Third GSM
            Console.WriteLine("\n" + GSM.IPhone4S);
        }
    }
}
