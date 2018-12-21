using System;
using System.Text;

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
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Price { get; set; }

        public string Owner { get; set; }

        public Battery BatterySpec { get; set; }

        public Display DisplaySpec { get; set; }


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

            result.AppendLine("Model: " + Model);
            result.AppendLine("Manufacturer: " + Manufacturer);
            result.AppendLine("Price: " + Price);
            result.AppendLine("Owner: " + Owner);
            result.AppendLine("Battery Specification: " + BatterySpec);
            result.AppendLine("Display Specification: " + DisplaySpec);

            return result.ToString();
        }
    }
}
