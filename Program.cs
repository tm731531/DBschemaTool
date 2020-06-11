using DBschemaTool.Factory;
using DBschemaTool.Helper;
using DBschemaTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBschemaTool
{
    class Program
    {
        public static string filePath = "";
        static string NameSpace = "SPMTool.Model";
        static string StoreProcedure = "";
        //static string ConfigConnectionName = "OracleConnectionString";
        static string ConfigConnectionName = "";
        static bool MSGetALLTableViewModel = false;

        static void Main(string[] args)
        {
            if (args.Length < 1) { Console.WriteLine("缺乏必要參數"); return; }

            try
            {
                InitSetting(args);

                if (!string.IsNullOrEmpty(StoreProcedure))
                {
                    Console.WriteLine($"NameSpace : {NameSpace}");
                    Console.WriteLine($"filePath : {filePath}");
                    Console.WriteLine($"StoreProcedure : {StoreProcedure}");
                    var spname = StoreProcedure.Split('(')[0].Trim();

                    var outputModel = new DBFactory(ConfigConnectionName).FugoRepository.GetSpDto(StoreProcedure);
                    outputModel = FillOutputModel(outputModel, spname);
                    ///Create Output Model
                    FileHelper.CreateCsFile(outputModel, "Output", spname);
                    ///Create Input Model
                    FileHelper.CreateCsFile(CleanString(new DBFactory(ConfigConnectionName).FugoRepository.GetSpInputDto(spname), spname), "Input", spname);
                }
                if (MSGetALLTableViewModel)
                {

                    ///Create Table Model
                    MakeCsFile($"{ConfigConnectionName}Table", new DBFactory(ConfigConnectionName).MSSQLRepository.GetTable().GroupBy(x => x.Table));

                    ///Create View Model
                    MakeCsFile($"{ConfigConnectionName}View", new DBFactory(ConfigConnectionName).MSSQLRepository.GetView().GroupBy(x => x.Table));

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

        }

        private static void InitSetting(string[] args)
        {
            for (int i = 0; i < args.Count(); ++i)
            {
                if (args[i].Trim().ToLower() == "-h")
                {
                    throw new Exception(@"
-h | Help 
-p | Folder Path 
-n | Name Space 
-sp | Store Procedure Name
-c | ConfigConnectionName 
-ms | GetMSSQL Table View Model
-");
                }
                if (args[i].Trim().ToLower() == "-n")
                {
                    NameSpace = args[i + 1];
                }
                if (args[i].Trim().ToLower() == "-p")
                {
                    filePath = args[i + 1];
                }
                if (args[i].Trim().ToLower() == "-sp")
                {
                    StoreProcedure = args[i + 1];
                }
                if (args[i].Trim().ToLower() == "-c")
                {
                    ConfigConnectionName = args[i + 1];
                }
                if (args[i].Trim().ToLower() == "-ms")
                {
                    MSGetALLTableViewModel = true;
                }
            }

        }

        private static void MakeCsFile(string msformalTable, IEnumerable<IGrouping<string, MsSQLTableDes>> enumerable)
        {
            foreach (var data in enumerable)
            {
                FileHelper.CreateCsFile(TableDesToList(data), msformalTable,
                    data.FirstOrDefault().Table);
            }
        }
        private static ICollection<string> TableDesToList(IGrouping<string, MsSQLTableDes> data)
        {
            List<string> returnLs = new List<string>();
            returnLs.Add($"using System; ");
            returnLs.Add($"using System.Collections.Generic;");
            returnLs.Add($"using System.ComponentModel.DataAnnotations;");
            returnLs.Add($"using System.ComponentModel.DataAnnotations.Schema;");
            returnLs.Add($"namespace {NameSpace}");
            returnLs.Add("{");
            returnLs.Add($"public class {data.FirstOrDefault().Table}");
            returnLs.Add("{");
            foreach (var t in data)
            {
                var isNullable = t.Isnull == "NO" ? "" : "?";
                AddSummary(returnLs, t);
                AddColumn(returnLs, t);
                AddMaxLength(returnLs, t);
                AddKey(returnLs, t);
                returnLs.Add($"        public {ConvertTypeMSSQL(t.DATA_TYPE)}{isNullable} @{t.Column}  " + " { get; set; }");
            }

            returnLs.Add("}");
            returnLs.Add("}");
            return returnLs;
        }

        private static void AddMaxLength(List<string> returnLs, MsSQLTableDes t)
        {
            if (t.MaxLength.HasValue && t.MaxLength > 0)
            {
                returnLs.Add($"        [MaxLength({t.MaxLength.Value})] ");
            }
        }

        private static void AddColumn(List<string> returnLs, MsSQLTableDes t)
        {
            returnLs.Add($"        [Column(\"{t.Column}\")] ");
        }

        private static void AddSummary(List<string> returnLs, MsSQLTableDes t)
        {
            returnLs.Add($"        ///<summary> ");
            if (!string.IsNullOrEmpty(t.Description))
            {

                foreach (var s in t.Description.Split('\n'))
                {

                    returnLs.Add($"        /// {s.Trim()} ");
                }
            }
            else
            {
                returnLs.Add($"        /// ");
            }
            returnLs.Add($"        /// </summary> ");
        }

        private static void AddKey(List<string> returnLs, MsSQLTableDes t)
        {
            if (t.IsKey) { returnLs.Add($"        [Key] "); }
        }

        private static List<string> FillOutputModel(List<string> outputModel, string spname)
        {
            outputModel.Insert(0, $"using System; ");
            outputModel.Insert(1, $"using System.Collections.Generic;");
            outputModel.Insert(2, $"using System.ComponentModel.DataAnnotations;");
            outputModel.Insert(3, $"using System.ComponentModel.DataAnnotations.Schema;");

            outputModel.Insert(4, $"namespace {NameSpace}.Output");
            outputModel.Insert(5, "{  ");

            outputModel.Insert(6, $"public class {spname}_Output  ");
            outputModel.Insert(7, "{  ");
            outputModel.Add("}");
            outputModel.Add("}");
            return outputModel;
        }

        private static List<string> CleanString(IEnumerable<string> temp, string spname)
        {
            List<string> returnLs = new List<string>();
            returnLs.Add($"using System; ");
            returnLs.Add($"using System.Collections.Generic;");
            returnLs.Add($"using System.ComponentModel.DataAnnotations;");
            returnLs.Add($"using System.ComponentModel.DataAnnotations.Schema;");
            returnLs.Add($"using {NameSpace}.Output;");
            returnLs.Add($"namespace {NameSpace}.Input");
            returnLs.Add("{");
            returnLs.Add($"    public class {spname}_Input");
            returnLs.Add("    {");
            var temps = string.Join("", temp.ToArray());
            foreach (var t in temps.Substring(temps.IndexOf('(') + 1, temps.IndexOf(')') - temps.IndexOf('(') - 1).Split(','))
            {
                var temp2 = t.Trim().Split(' ');
                returnLs.Add($"        public {ConvertType(temp2.Last(), spname)}  {temp2[0]}  " + " { get; set; }");
            }

            returnLs.Add("    }");
            returnLs.Add("}");
            return returnLs;
        }
        private static string ConvertType(string target, string spname)
        {
            string returnStr = string.Empty;
            switch (target.ToUpper())
            {
                case "NUMBER":
                    returnStr = "decimal";
                    break;
                case "NVARCHAR2":
                case "NCHAR":
                case "NCLOB":
                    returnStr = "string";
                    break;
                case "DATE":
                    returnStr = "DateTime";
                    break;
                case "BLOB":
                case "BFILE":
                    returnStr = "byte[]";
                    break;
                case "SYS_REFCURSOR":
                    returnStr = $"List<{spname}_Output>";
                    break;

                default:
                    returnStr = "string";
                    break;
            }
            return returnStr;

        }
        private static string ConvertTypeMSSQL(string target)
        {
            string returnStr = string.Empty;
            switch (target.ToLower())
            {
                case "bigint":
                    returnStr = "long";
                    break;
                case "bit":
                    returnStr = "bool";
                    break;
                case "datetimeoffset":
                    returnStr = "DateTimeOffset";
                    break;
                case "float":
                    returnStr = "double";
                    break;
                case "int":
                    returnStr = "int";
                    break;
                case "real":
                    returnStr = "float";
                    break;
                case "smallint":
                    returnStr = "short";
                    break;
                case "time":
                    returnStr = "TimeSpan";
                    break;
                case "timestamp":
                    returnStr = "long";
                    break;
                case "tinyint":
                    returnStr = "byte";
                    break;
                case "uniqueidentifier":
                    returnStr = "Guid";
                    break;
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                    returnStr = "DateTime";
                    break;
                case "decimal":
                case "money":
                case "numeric":
                case "smallmoney":
                    returnStr = "decimal";
                    break;
                case "image":
                case "varbinary":
                case "binary":
                    returnStr = "byte[]";
                    break;
                case "nvarchar":
                case "nchar":
                case "ntext":
                case "char":
                case "text":
                case "varchar":
                    returnStr = "string";
                    break;
            }
            return returnStr;
        }
    }
}
