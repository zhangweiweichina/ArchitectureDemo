using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.MEF.Demo
{
    [Export("MusicBook", typeof(IBookService))]
    public class MusicBook : IBookService
    {
        //导出私有属性
        [Export(typeof(string))]
        private string _privateBookName = "Private Music BookName";

        //导出公有属性
        [Export(typeof(string))]
        public string _publicBookName = "Public Music BookName";


        public string BookName { get; set; }

        [Export(typeof(Func<string>))]
        public string GetBookName()
        {
            return "MusicBook";
        }

        //导出私有方法
        [Export(typeof(Func<int, string>))]
        private string GetBookPrice(int price)
        {
            return "$" + price;
        }
    }

    [Export("MathBook", typeof(IBookService))]
    public class MathBook : IBookService
    {
        public string BookName { get; set; }

        public string GetBookName()
        {
            return "MathBook";
        }
    }

    [Export("HistoryBook", typeof(IBookService))]
    public class HistoryBook : IBookService
    {
        public string BookName { get; set; }

        public string GetBookName()
        {
            return "HistoryBook";
        }
    }


}
