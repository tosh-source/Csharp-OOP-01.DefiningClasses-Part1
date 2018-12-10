using System;

namespace DefineClass
{
    class GSM
    {
        private const string model = "Nokia 3310 (2017)";
        private const string manufacturer = "Nokia";
        private const string price = "60 EUR";
        private const string owner = "Tosh";

        public static void Main(string[] args)
        {
            Console.WriteLine(model + "\n" +
                              manufacturer + "\n" +
                              price + "\n" +
                              owner + "\n\n" +
                              Battery.batteryModel + "\n" +
                              Battery.hoursIdle + "\n" +
                              Battery.hoursTalk + "\n\n" +
                              Display.displaySize + "\n" +
                              Display.displayColors);
        }
    }
}
