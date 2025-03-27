using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    interface IPrintable
    {
        string Print();
    }

    class Document : IPrintable
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Document(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public string Print()
        {
            return $"Документ: {Title}\nСодержание: {Content}";
        }
    }

    class Report : IPrintable
    {
        public string ReportName { get; set; }
        public DateTime Date { get; set; }
        public Report(string reportName, DateTime date)
        {
            ReportName = reportName;
            Date = date;
        }
        public string Print()
        {
            return $"Отчёт: {ReportName}\nДата: {Date.ToShortDateString()}";
        }
    }

    class Task2
    {
        public static void Execute()
        {
            List<IPrintable> printables = new List<IPrintable>
            {
                new Document("Контракт", "Договор на поставку товаров."),
                new Report("Годовой отчёт", DateTime.Now)
            };

            foreach (var printable in printables)
            {
                Console.WriteLine(printable.Print());
                Console.WriteLine("----------------------");
            }
        }
    }

}
