using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeworkMobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private string price;
        private string owner;
        private Battery batterySpec;
        private Display displaySpec;

        public string Model
        {
            get { return model; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                manufacturer = value;
            }
        }

        public string Price
        {
            get { return price; }

            set
            {
                if (value != null)
                {

                }
                else if (!(Regex.IsMatch(value, @"\d")))  //check if there is no digit
                {
                    throw new ArgumentException();
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return owner; }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }

                this.owner = value;
            }
        }

        public Battery BatterySpec
        {
            get { return batterySpec; }

            set
            {

                this.batterySpec = value;
            }
        }

        public Display DisplaySpec
        {
            get { return displaySpec; }

            set
            {

                this.displaySpec = value;
            }
        }


        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, null, null)
        {

        }
        public GSM(string model, string manufacturer, string price = null, string owner = null, Battery batterySpec = null, Display displaySpec = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatterySpec = batterySpec;
            this.DisplaySpec = displaySpec;
        }

        public static void Main(string[] args)
        {

        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("Model: " + this.Model);
            result.AppendLine("Manufacturer: " + this.Manufacturer);
            result.AppendLine("Price: " + this.Price);
            result.AppendLine("Owner: " + this.Owner);
            result.AppendLine("Battery Specification: " + this.BatterySpec);
            result.AppendLine("Display Specification: " + this.DisplaySpec);

            return result.ToString();
        }
    }
}
