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
         $"{AppDomain.CurrentDomain.FriendlyName}  export     <（Locres/Uasset/Umap）文件路径>  <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName}  import     <(txt/csv) 文件路径>  <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} -import     <(txt/csv) 文件路径>  <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName}  exportall  <文件夹> <文本（txt/csv）> <Options>\n" +
         $"{AppDomain.CurrentDomain.FriendlyName}  importall  <文件夹> <文本（txt/csv）>  <Options>\n\n" +
         "【↓↓↓↓↓↓ - 导入原文件，文件保持原名，直接修改原文件。 -↓↓↓↓↓↓】\n\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} -importall  <文件夹> <文本（txt/csv）>  <Options>\n\n" +
         "【↑↑↑↑↑↑- 对于不重命名文件的导入，请谨慎使用此命令 -↑↑↑↑↑↑】\n\n" +

          "Options:\n" +
          "在GUI中使用你之前应用的最后一个过滤器, 在命令后添加 (-f \\ -filter) \n" +
          "筛选仅适用于名称表 " +
            "\n(导入时请记住应用相同的筛选)\n\n" +

          "导出不包含名称的文件，请使用 (-nn \\ -NoName)" +
          "\n(导入时请记住使用此命令)\n\n" +

           "导出 CSV 格式文件，请使用 (-c \\ -csv)" +
          "\n(导入时请记住使用此命令)\n\n" +

          "使用方法2 (-m2 \\ -method2)" +
          "\n(导入时请记住使用此命令)\n\n" +

          "例:\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} export Actions.uasset\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} import Actions.uasset.txt\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} exportall Actions text.txt\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} importall Actions text.txt\n" +
         $"{AppDomain.CurrentDomain.FriendlyName} export Actions.uasset -c （导出CSV格式，最好用于loces导出设置）\n";


        public static Args GetArgs(int Index, string[] args)
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
                        args1 |= Args.noname;
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
                    case "-method2":
                    case "-m2":
                    case "-c":
                    case "-csv":
                        throw new Exception("无效参数。\n\n" + commandlines);
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
