using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMobilePhone
{
    public class Call
    {
        //Fields
        private DateTime date = DateTime.Now;
        private DateTime time = DateTime.Now;
        private List<string> dialledPhoneNumber = new List<string>();
        private List<uint> duration = new List<uint>();  //duration in seconds

        //Property
        public string Date
        {
            get
            {
                return this.date.ToString("HH.mm:SS");
            }
        }

        public string Time
        {
            get
            {
                return this.time.ToString("dd-MM-yyyy");
            }
        }

        public List<string> DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public List<uint> Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        //Def. constructor
        public Call()
        {

        }
    }
}
