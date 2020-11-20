using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Command

{
    class Excel
    {
        string path { get; set; }
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        _Excel.Range range;
        int tasks;

        enum TaskSegregator
        {
            todo, impnow, notimpnow, implater, notimplater
        };

        TaskSegregator taskseg;

        public Excel(string path)
        {
            //path to save data
            this.path = path;
            FileInfo file = new FileInfo(path);
            string filepath = Path.GetFullPath(path);
            Console.WriteLine(filepath);
            // string curFile = @"c:\temp\test.xlsx";
            //Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
             
            //System.IO.File.Exists(filepath) ? OpenExistingExcelFile(filepath) : CreateNewExcelFile(filepath);
            if (System.IO.File.Exists(filepath)){
                OpenExistingExcelFile(filepath); }
            else {
                CreateNewExcelFile(filepath); }

            //range = ws.UsedRange;
            tasks = Howmanylines() - 1;
            //range formating
            FormatCells("C2", "C100000", "d/m/yyyy");
            excel.Visible = true;
            excel.UserControl = true;

        }
        public string ReadCell(int i, int j)
        {
            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value2;
            }
            else
                return "";
        }
        public void WriteCell(int i, int j, string message)
        {
            ws.Cells[i, j].Value2 = message;
        }
        private void OpenExistingExcelFile(string filepath)
        {
            Console.WriteLine("istnieje");
            wb = excel.Workbooks.Open(filepath);
            ws = (_Excel.Worksheet)wb.ActiveSheet;
        }
        private void CreateNewExcelFile(string filepath)
        {
            Console.WriteLine("nie istnieje ");
            wb = (_Excel.Workbook)(excel.Workbooks.Add(System.Reflection.Missing.Value));
            wb.SaveAs(filepath);
            wb.Close();
            wb = excel.Workbooks.Open(filepath);
            ws = (_Excel.Worksheet)wb.ActiveSheet;
            NewSheetConfig();
            Save();
        }
        private void NewSheetConfig()
        {
            WriteCell(1, 1, "task");
            WriteCell(1, 2, "date");
            WriteCell(1, 3, "wheretaskis");
        }
        public int Howmanylines()
        {
            Console.WriteLine(range.Rows.Count);
            return range.Rows.Count;

        }
        public void AddTask(string name, string date, int whattodoinmylife)
        {
            WriteCell(1, tasks + 2, name);
            WriteCell(2, tasks + 2, date);
            
            Save();
        }
        private void FormatCells(string cell1, string cell2, string format )
        {
            _Excel.Range formatRange;
            formatRange = ws.get_Range(cell1, cell2);
            formatRange.NumberFormat = format;

        }
        public void Save()
        {
            wb.Save();
        }
        public void Close()
        {
            wb.Close();
            excel.Quit();
        }
        ~Excel()
        {
            // WriteCell(1, 1,"mess");
            wb.Close();
            excel.Quit();
        }
    }
}