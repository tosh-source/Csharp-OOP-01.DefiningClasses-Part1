using System;

namespace HomeworkMobilePhone
{
    public class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;

        public string BatteryModel
        {
            get { return batteryModel; }

            set
            {
                this.batteryModel = value;
            }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }

            set
            {
                hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }

            set
            {
                hoursTalk = value;
            }
        }


        public override string ToString()
        {

            return base.ToString();
        }
    }
}
