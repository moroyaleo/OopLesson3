using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
            public void DuplicateKeySample()
            {
                // ディクショナリの初期化
                var dict = new Dictionary<string, List<string>>() {
               { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
               { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
            };

                // ディクショナリに追加
                var key = "EC";
                var value = "電子商取引";
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(value);
                }
                else
                {
                    dict[key] = new List<string> { value };
                }

                // ディクショナリの内容を列挙
                foreach (var item in dict)
                {
                    foreach (var term in item.Value)
                    {
                        Console.WriteLine("{0} : {1}", item.Key, term);
                    }
                }
            }
            //var flowerDict = new Dictionary<string, int>()
            // {
            // ["sunflower"] = 400,
            // ["pansy"] = 300,
            // ["tulip"] = 350,
            // ["rose"] = 500,
            // ["dahlia"] = 450,
            // };
            //  flowerDict["violet"] = 600;
            //flowerDict.Add("violet",600);

            // foreach (var item in flowerDict)
            // {
            // Console.WriteLine(${ item.Key}) = item.Value
            // }

            //var lines = File.ReadAllLines("sample.txt");
            //var we = new WordsExtractor(lines);
            //foreach (var word in we.Extract())
            //{
            //    Console.WriteLine(word)
            //リスト
            //new Employee(100,"清水遼久"),
            //new Employee(112,"斧沢洋和"),
            //new Employee(125,"岩瀬奈央子"),
            //new Employee(143,"山田太郎"),
            //new Employee(148,"清水遼久"),
            //new Employee(152,"清水遼久"),
            //new Employee(155,"清水遼久"),
            //new Employee(161,"清水遼久"),
            // var dict = new Dictionary<MonthDays, string> {
            //        {new MonthDays(3.5),"aday" },
            //        {new MonthDays(8.4),"bday" },
            //        {new MonthDays(10,3),"登山の日" },
            //        //};
            //        var other = obj as MonthDay(8, 4);
            //    var s = Dictionary[md];
            //    Console.WriteLine(s);

            //}

        
    }
}

