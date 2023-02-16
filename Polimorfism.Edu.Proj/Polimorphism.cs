using System;
using static System.Net.Mime.MediaTypeNames;

namespace Polimorfism.Edu.Proj
{
    internal class Polimorphism
    {
        static void Main(string[] args)
        {
            MyHolidaysBase b = new();
            b.SetOrUpdateFoundationDay();
            b.SetOrUpdateNewYearDate();
            b.PrintHolidays();

            
            ChineseHolidaysDerivedOverrided c = new();
            c.SetOrUpdateFoundationDay();
            c.SetOrUpdateNewYearDate();
            Console.WriteLine(new string('-', 52) + "Overrided class" + new string('-', 52));
            c.PrintHolidays();
            b = c;
            b.SetOrUpdateFoundationDay();
            b.SetOrUpdateNewYearDate();
            Console.WriteLine(new string('-', 45) + "Overrided class casted to base" + new string('-', 45));
            b.PrintHolidays();
         

            IranianHolidaysDerivedNew i = new();
            i.SetOrUpdateFoundationDay();
            i.SetOrUpdateNewYearDate();
            Console.WriteLine(new string('-', 52) + "Class with 'new'" + new string('-', 52));
            i.PrintHolidays();
            b = i;
            b.SetOrUpdateFoundationDay();
            b.SetOrUpdateNewYearDate();
            Console.WriteLine(new string('-', 45) + "Class with 'new' casted to base" + new string('-', 44));
            b.PrintHolidays();
        }
    }
    public class MyHolidaysBase
    {
        public Dictionary<string, DateTime> _myHolidays;
        
        public void PrintHolidays ()
        {
            foreach (var item in _myHolidays)
            {
                Console.WriteLine("{0} \t will be at \t {1}", item.Key, item.Value.ToShortDateString());
            }
        }
        public virtual void SetOrUpdateNewYearDate() 
        {
           _myHolidays.Remove("New Year");
           _myHolidays.Add("New Year", new DateTime((DateTime.Now.Year + 1), 1, 1));
        }

        public virtual void SetOrUpdateFoundationDay()
        {
            _myHolidays.Remove("Foundation Day");
            _myHolidays.Add("Foundation Day", new DateTime((DateTime.Now.Year + 1), 6, 12));
        }

        public MyHolidaysBase()
        {
            _myHolidays = new Dictionary<string, DateTime>();
        }
    }
    
    public class ChineseHolidaysDerivedOverrided : MyHolidaysBase
    {
        public override void SetOrUpdateNewYearDate()
        {
            _myHolidays.Remove("New Year");
            _myHolidays.Add("New Year", new DateTime((DateTime.Now.Year + 1), 2, 12));
        }

        public override void SetOrUpdateFoundationDay()
        {
            _myHolidays.Remove("Foundation Day");
            _myHolidays.Add("Foundation Day", new DateTime((DateTime.Now.Year + 1), 10, 1));
          
        }

    }

    public class IranianHolidaysDerivedNew : MyHolidaysBase
    {
        public new void SetOrUpdateNewYearDate()
        {
            _myHolidays.Remove("New Year");
            _myHolidays.Add("New Year", new DateTime((DateTime.Now.Year + 1), 3, 21));
        }

        public new void SetOrUpdateFoundationDay()
        {
            _myHolidays.Remove("Foundation Day");
            _myHolidays.Add("Foundation Day", new DateTime((DateTime.Now.Year + 1), 04, 1));

        }
    }
}