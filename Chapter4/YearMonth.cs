using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class YearMonth
    {
        static void Main(string[] args)
        {
            //4.1.1
            public int Year{ get;private set; }
        public int Month { get; private set; }
        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;

        }
        //プロパティ
        //コンストラクタ

        //4.1.2
        //Is21Centuryプロパティを追加
        public bool Is21Century
        {
            get {
                return 2001 <= Year && Year <= 2100;

            }
        }

        //4.1.3
        //AddOneMonth()メソッドを追加
        public YearMonth AddOneMonth()
        {

        }
        //4.1.4
        //ToString()メソッドのオーバーライド
        public override string ToString()
        {
          
        }
    }  
    
}
