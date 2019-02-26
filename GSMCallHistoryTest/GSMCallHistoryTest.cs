using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkMobilePhone;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {

            GSM s8 = new GSM("Galaxy S8 Plus", "Samsung", "600$", owner: "Ben",
                                batterySpec: new Battery { BatteryModel = "Samsung 3500mAh battery", HoursIdle = 96, HoursTalk = 27, BatteryType = BatteryType.LiIon },
                                displaySpec: new Display());

            int countOfCalls = 5;
            Call[] calls = new Call[countOfCalls];
            int clientPhoneNumber = 889977550;

            for (int index = 0; index < countOfCalls; index++)
            {
                clientPhoneNumber = clientPhoneNumber + index;                //simple random number adding
                calls[index] = new Call();
                calls[index].DialedPhoneNumber = "0" + clientPhoneNumber;

                calls[index].Duration = 10m + index;                       //duration is in seconds (start from 10 seconds for first call )
            }

            s8.AddCalls(calls);
        }
    }
}
