using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace ExcelSplitter
{
    static class ActualWorker
    {
        public static Excel.Application GetExcelApp()
        {
            return (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
        }

        
    }
}
