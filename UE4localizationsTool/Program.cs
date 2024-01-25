using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace UE4localizationsTool
{
    internal static class Program
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;


        public static string commandlines =
         $"{AppDomain.CurrentDomain.FriendlyName}  export     <(Locres/Uasset) FilePath>  <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName}  import     <(txt) FilePath>  <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} -import     <(txt) FilePath>  <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName}  exportall  <Folder> <TxtFile> <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName}  importall  <Folder> <TxtFile>  <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} -importall  <Folder> <TxtFile>  <Options>\n\n" +
          "- for import without rename file be careful with this command.\n\n" +

          "Options:\n" +
          "To use last filter you applied before in GUI, add (-f \\ -filter) after command line\n" +
          "filter will apply only in name table (Remember to apply the same filter when importing)\n\n" +

          "导出不包含名称的文件，请使用 (-nn \\ -NoName)" +
          "\n(导入时请记住使用此命令)\n\n" +

          "Examples:\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} export Actions.uasset\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} import Actions.uasset.txt\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} exportall Actions text.txt\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} importall Actions text.txt\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} export Actions.uasset -c （导出CSV格式，最好用于loces导出设置）\n";

        public static (bool UseFilter, bool NoName) GetArgs(int Index, string[] args)
        {
            Args args1 = new Args();

            for (int n = Index; n < args.Length; n++)
            {
                switch (args[n].ToLower())
                {
                    case "-f":
                    case "-filter":
                        args1 |= Args.filter;
                        break;
                    case "-nn":
                    case "-noname":
                        noname = true;
                        break;
                    case "-m2":
                    case "-method2":
                        args1 |= Args.method2;
                        break;
                    
                    case "-c":
                    case "-csv":
                        args1 |= Args.CSV;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("无效命令： " + args[n]);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            return args1;
        }


        public static void CheckArges(int Index, string[] args)
        {
            for (int n = 0; n < Index; n++)
            {
                switch (args[n].ToLower())
                {
                    case "-f":
                    case "-filter":
                    case "-nn":
                    case "-noname":
                        throw new Exception("Invalid number of arguments.\n\n" + commandlines);
                }
            }
        }



        [STAThread]

        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                if (args.Length == 1 && (args[0].EndsWith(".uasset") || args[0].EndsWith(".umap") || args[0].EndsWith(".locres")))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    var FrmMain = new FrmMain();
                    FrmMain.Show();
                    FrmMain.LoadFile(args[0]);
                    Application.Run(FrmMain);
                    return;
                }


                AttachConsole(ATTACH_PARENT_PROCESS);
                Console.WriteLine("");
                //  Console.SetCursorPosition(0, Console.CursorTop + 1);

                if (args.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("无效参数。\n\n" + commandlines);
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                try
                {

                    if (args[0].ToLower() == "importall" || args[0].ToLower() == "-importall" || args[0].ToLower() == "exportall")
                    {
                        if (args.Length < 3)
                        {
                            throw new Exception("无效参数。\n\n" + commandlines);
                        }

                        CheckArges(3, args);
                        new Commands(args[0], args[1] + "*" + args[2], GetArgs(3, args));
                    }
                    else
                    {
                        CheckArges(2, args);
                        new Commands(args[0], args[1], GetArgs(2, args));
                    }

                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n"+ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
