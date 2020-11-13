using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class MonthDays
    {
        public int Day { get; private set; }
        public int Month { get; private set; }

        public MonthDay(int month,int day)
        {
            this.Month = month;
            this.Day day;

        }
        //MonthDayどうしの比較をする
        public override bool Equals(object obj)
        {
            var other = obj as MonthDay(8, 4);
            var s = Dictionary[md];
            Console.WriteLine(s);
        }
    }
}
