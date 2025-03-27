using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    public interface IPrintable
    {
        string Print();
    }

    public class Document : IPrintable
    {
        public string Content { get; set; }

        public string Print()
        {
            return $"Document Content: {Content}";
        }
    }

    public class Report : IPrintable
    {
        public string Title { get; set; }

        public string Print()
        {
            return $"Report Title: {Title}";
        }
}

// Демонстрация универсальности интерфейса
var printableList = new List<IPrintable>
{
    new Document { Content = "Project Plan" },
    new Report { Title = "Annual Report" }
};

foreach (var printable in printableList)
{
    Console.WriteLine(printable.Print());
}

}
