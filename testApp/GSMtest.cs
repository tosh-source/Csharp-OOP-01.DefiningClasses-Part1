using HomeworkMobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testApp
{
    class GSMtest
    {
        static void Main(string[] args)
        {
            //Define array of devices (GSMs)
            var gsm = new GSM[2];
            
            //First GSM
            gsm[0] = new GSM("S 7 Edge", "Samsung", "500$", owner: "Frank", batterySpec: new Battery(), displaySpec: new Display());
            Console.WriteLine("First GSM\n" + gsm[0].ToString());

            //Second GSM
            gsm[1] = new GSM("S 7 Edge", "Samsung", "500$", owner: "Frank", 
                                batterySpec: new Battery { BatteryModel = "Samsung 3600mAh battery", HoursIdle = 96, HoursTalk = 27, BatteryType = BatteryType.LiIon }, 
                                displaySpec: new Display());
            Console.WriteLine("\nSecond GSM\n" + gsm[1].ToString());

            //Third GSM
            Console.WriteLine("\n" + GSM.IPhone4S);

            //Manipulate Call (history) class
            Console.WriteLine(gsm[1].CallHistory);
        }
    }
}
