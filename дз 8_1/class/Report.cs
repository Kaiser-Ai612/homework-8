using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_8_1.@class
{
    internal class Report
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Employee Author { get; set; }
        public bool Odobrenie { get; set; }

        public Report(string text, DateTime date, Employee author)
        {
            Text = text;
            Date = date;
            Author = author;
            Odobrenie = false;
        }
    }
}
