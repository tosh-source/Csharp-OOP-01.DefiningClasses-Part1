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
        { //Problem 12. Call history test
            
            //12.1 Create an instance of the GSM class.
            GSM s8 = new GSM("Galaxy S8 Plus", "Samsung", "600$", owner: "Ben",
                                batterySpec: new Battery { BatteryModel = "Samsung 3500mAh battery", HoursIdle = 96, HoursTalk = 27, BatteryType = BatteryType.LiIon },
                                displaySpec: new Display());

            //12.2 Add few calls.
            int countOfCalls = 5;
            Call[] allCalls = new Call[countOfCalls];
            int clientPhoneNumber = 889977550;

            for (int index = 0; index < countOfCalls; index++)
            {
                clientPhoneNumber = clientPhoneNumber + index;                //simple random number adding
                allCalls[index] = new Call();
                allCalls[index].DialedPhoneNumber = "0" + clientPhoneNumber;

                allCalls[index].Duration = 10m + index;                       //duration is in seconds (start from 10 seconds for first call )
            }

            s8.AddCalls(allCalls);

            //12.3 Display the information about the calls.
            Console.WriteLine(s8.CallHistoryToString());


        }
    }
}
