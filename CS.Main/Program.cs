using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ActualWorker.GetExcelApp().Workbooks[1].Name);
            Console.ReadLine();
        }
    }

    


}
