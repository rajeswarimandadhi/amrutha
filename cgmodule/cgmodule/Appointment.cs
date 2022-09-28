using System;
using System.Collections.Generic;
using System.Text;

namespace Appointment
{
    class Program
    {
        static void Main2(string[] args)
        {
            Appointment obj = new Appointment("Tuesday", 15);
            var res = obj.CheckSlot();
            Console.WriteLine(res);
        }
        public class Appointment
        {
            string Day { get; set; }
            int Time { get; set; }
        public Appointment (string Day, int Time)
            {
                this.Day = Day;
                this.Time = Time;
            }
        public string CheckSlot()
            {
                if (this.Day == "Monday" && this.Time >= 8 && this.Time <= 17) return "Available";               
                if (this.Day == "Tuesday" && this.Time >= 8 && this.Time <= 15) return "Available";
                if (this.Day == "Wednesday" && this.Time >= 8 && this.Time <= 13) return "Available";
                if (this.Day == "Thursday" && this.Time >= 8 && this.Time <= 11) return "Available";
                if (this.Day == "Fridayday" && this.Time >= 8 && this.Time <= 9) return "Available";
                return "Not Available";

            }

        private Dictionary<string,int> GetTimeSlots()
            {
                Dictionary<string, int> d = new Dictionary<string, int>();
                d.Add("Monday", 17);
                d.Add("Tuesday", 15);
                d.Add("Wedday", 13);
                d.Add("Thursday", 11);
                d.Add("Friday", 9);
                return d;


            }
        }
    }
}
