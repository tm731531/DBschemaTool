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
            var filePath = Path.Combine(Program.filePath, $"{v}/{spname}.cs");
            if (!Directory.Exists($"{v}"))
            {
                Directory.CreateDirectory($"{v}");
            }
            FlashFile(sl, filePath);
        }

        private static void CreateCsFileInput(ICollection<string> sl, string spname)
        {
            var filePath =Path.Combine(Program.filePath, $"Input/{spname}_Input.cs");
            if (!Directory.Exists("Input"))
            {
                Directory.CreateDirectory("Input");
            }
            FlashFile(sl, filePath);
        }

        private static void CreateCsFileOutput(ICollection<string> sl, string spname)
        {
            var filePath = Path.Combine(Program.filePath, $"Output/{spname}_Output.cs");
            if (!Directory.Exists("Output"))
            {
                Directory.CreateDirectory("Output");
            }
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
