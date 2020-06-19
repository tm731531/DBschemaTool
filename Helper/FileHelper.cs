using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBschemaTool.Helper
{
    public class FileHelper
    {

        public static void CreateCsFile(ICollection<string> sl, string v,string spname)
        {
            if (v.ToUpper() == "INPUT") { CreateCsFileInput(sl, spname); }
           else if (v.ToUpper() == "OUTPUT") { CreateCsFileOutput(sl, spname); }
            else  { CreateCsFileMSSQL(sl,v, spname); };
        }

        private static void CreateCsFileMSSQL(ICollection<string> sl, string v, string spname)
        {
            var dicPath = Path.Combine(Program.filePath, $"{v}");
            var filePath = Path.Combine(dicPath, $"{spname}.cs");
            CheckDicExists(dicPath);
            FlashFile(sl, filePath);
        }

        private static void CheckDicExists(string dicPath)
        {
            if (!Directory.Exists($"{dicPath}"))
            {
                Directory.CreateDirectory($"{dicPath}");
            }
        }

        private static void CreateCsFileInput(ICollection<string> sl, string spname)
        {
            var dicPath = Path.Combine(Program.filePath, $"INPUT");
            var filePath = Path.Combine(dicPath, $"{spname}.cs");
            CheckDicExists(dicPath);
            FlashFile(sl, filePath);
        }

        private static void CreateCsFileOutput(ICollection<string> sl, string spname)
        {
            var dicPath = Path.Combine(Program.filePath, $"OUTPUT");
            var filePath = Path.Combine(dicPath, $"{spname}.cs");
            CheckDicExists(dicPath);
            FlashFile(sl, filePath);
        }

        private static void FlashFile(ICollection<string> sl, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            File.AppendAllLines(filePath, sl);
        }
    }
}
