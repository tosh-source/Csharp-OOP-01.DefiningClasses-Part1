using System;
using System.Text;

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
            var result = new StringBuilder();

            if (BatteryModel == null || BatteryModel == string.Empty)
            {
                result.AppendLine("There is no battery information.");
            }
            else
            {
                result.AppendLine("Battery Model: " + this.BatteryModel);
            }

            if (HoursIdle == 0)
            {
                result.AppendLine("There is no information about \"Idle Hours\".");
            }
            else
            {
                result.AppendLine("\"Idle Hours\": " + this.HoursIdle);
            }

            if (HoursTalk == 0)
            {
                result.Append("There is no information about \"Talk Hours\".");
            }
            else
            {
                result.Append("\"Talk Hours\": " + this.HoursTalk);
            }

            return result.ToString();
        }
    }
}
