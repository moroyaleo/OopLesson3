﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class YearMonth
    {
        //4.1.1
        public int Year { get; private set; }
        public int Month { get; private set; }
        //コンストラクタ
        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        //4.1.2
        //Is21Centuryプロパティを追加
        public bool Is21Century
        {
            get
            {
                return 2001 <= Year && Year <= 2100;
            }
        }

        //4.1.3
        //AddOneMonth()メソッドを追加
        public YearMonth AddOneMonth()
        {
            if (Month < 12)
            {
                return new YearMonth(Year, Month + 1);
            }
            else
            {
                return new YearMonth(Year + 1, 1);
            }
        }
        //4.1.4
        //ToString()メソッドのオーバーライド
        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }

    }
}

