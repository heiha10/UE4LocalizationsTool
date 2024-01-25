using AssetParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UE4localizationsTool.Core.locres;
using UE4localizationsTool.Helper;

namespace UE4localizationsTool
{
    [Flags]
    public enum Args
    {
        filter = 1 << 0,
        noname = 1 << 1,
        method2 = 1 << 2,
        CSV = 1 << 3,
    }



    public class Commands
    {
        private List<List<string>> Strings;
        private string TextFileExtension = ".txt";
        public Args Flags;

        private bool UseMatching = false;
        private bool RegularExpression = false;
        private bool ReverseMode = false;
        private List<string> ArrayValues;
        public Commands(string Options, string SourcePath, Args args)
        {
            Flags = args;
            if (Flags.HasFlag(Args.filter))
            {
                GetFilterValues();
            }

            if (Flags.HasFlag(Args.CSV))
            {

                TextFileExtension = ".csv";
            }
            string[] Paths;
            string ConsoleText;
            string[] rows;
            switch (Options.ToLower())
            {
                case "export"://Single File
                    Strings = new List<List<string>>();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    ConsoleText = $"Exporting... '{Path.GetFileName(SourcePath)}' ";
                    Console.WriteLine(ConsoleText);
                    Console.ForegroundColor = ConsoleColor.White;

                    Strings = Export(SourcePath);

                    if (Flags.HasFlag(Args.filter))
                    {
                        Strings = ApplyFilter(Strings);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(ConsoleText.Length, Console.CursorTop - 1);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.White;

                    SaveTextFile(SourcePath + TextFileExtension);


                    break;
                case "exportall"://Folders
                    Strings = new List<List<string>>();
                    Paths = SourcePath.Split(new char[] { '*' }, 2);
                    ExportFolder(Paths[0]);
                    SaveTextFile(Paths[1]);
                    break;

                case "import"://Single File
                case "-import"://Single File Without rename
                    Console.ForegroundColor = ConsoleColor.Blue;
                    ConsoleText = $"Importing... '{Path.GetFileName(SourcePath)}' ";
                    Console.WriteLine(ConsoleText);
                    Console.ForegroundColor = ConsoleColor.White;

                    if (!SourcePath.EndsWith(TextFileExtension, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception("无效的文本类型： " + Path.GetFileName(SourcePath));
                    }



                    if (Flags.HasFlag(Args.CSV))
                    {
                        rows = CSVFile.Instance.Load(SourcePath, Flags.HasFlag(Args.noname));
                    }
                    else
                    {
                        rows = File.ReadAllLines(SourcePath);
                    }

                    Import(Path.ChangeExtension(SourcePath, null), File.ReadAllLines(SourcePath), Options.ToLower());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(ConsoleText.Length, Console.CursorTop - 1);
                    Console.WriteLine("Done");
                    Console.ForegroundColor = ConsoleColor.White;


                    break;

                case "importall"://Folders
                case "-importall"://Folders Without rename Files
                    Paths = SourcePath.Split(new char[] { '*' }, 2);

                    if (!Paths[1].EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rows = File.ReadAllLines(Paths[1]);
                    }

                    ImportFolder(Paths[0], File.ReadAllLines(Paths[1]), Options.ToLower());
                    break;
                default:
                    throw new Exception("参数无效。\n" + Program.commandlines);
            }

        }


        private void SaveTextFile(string FilePath)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string ConsoleText = "Saving text file... ";
            Console.WriteLine(ConsoleText);
            Console.ForegroundColor = ConsoleColor.White;


            if (Flags.HasFlag(Args.CSV))
            {
                CSVFile.Instance.Save(Strings, FilePath, Flags.HasFlag(Args.noname));

                goto End;
            }

            string[] stringsArray = new string[Strings.Count];
            int i = 0;

            foreach (var item in Strings)
            {
                if (item[0] == "[~PATHFile~]")
                {
                    stringsArray[i] = item[1];
                }
                else
                {
                    if (!Flags.HasFlag(Args.noname))
                    {
                        stringsArray[i] = item[0] + "=" + item[1];
                    }
                    else
                    {
                        stringsArray[i] = item[1];
                    }
                }
                i++;
            }
            File.WriteAllLines(FilePath, stringsArray);
        End:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(ConsoleText.Length, Console.CursorTop - 1);
            Console.WriteLine("Done");
            Console.ForegroundColor = ConsoleColor.White;
        }


        private List<List<string>> Export(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                throw new Exception("文件不存在： " + FilePath);
            }


            if (FilePath.EndsWith(".locres", StringComparison.OrdinalIgnoreCase))
            {
                IAsset locres = new LocresFile(FilePath);
                return locres.ExtractTexts();
                //  SizeOfRecord = locres.Strings.Count;
            }
            else if (FilePath.EndsWith(".uasset", StringComparison.OrdinalIgnoreCase))
            {
                Uasset Uasset = new Uasset(FilePath);
                Uexp Uexp = new Uexp(Uasset);
                return Uexp.Strings;
                //  SizeOfRecord = Uexp.Strings.Count;
            }
            else
            {
                throw new Exception("无效的语言文件类型： " + Path.GetFileName(FilePath));
            }
        }


        private void ExportFolder(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                throw new Exception("目录不存在： " + FolderPath);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            string ConsoleText = "Scaning for files...";
            Console.WriteLine(ConsoleText);
            Console.ForegroundColor = ConsoleColor.White;

            string[] LanguageFiles = Directory.GetFiles(FolderPath, "*.*", SearchOption.AllDirectories).Where(x => x.EndsWith(".locres", StringComparison.OrdinalIgnoreCase) || x.EndsWith(".uasset", StringComparison.OrdinalIgnoreCase) || x.EndsWith(".umap", StringComparison.OrdinalIgnoreCase)).ToArray<string>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Done\n");
            Console.ForegroundColor = ConsoleColor.White;

            if (LanguageFiles.Count() == 0)
            {
                throw new Exception($"“｛FolderPath｝”不包含任何语言文件。");
            }

            for (int i = 0; i < LanguageFiles.Count(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                ConsoleText = $"[{ i + 1}:{LanguageFiles.Count()}] Exporting... '{Path.GetFileName(LanguageFiles[i])}' ";
                Console.WriteLine(ConsoleText);
                Console.ForegroundColor = ConsoleColor.White;

                int ThisPosition = Strings.Count - 1;
                try
                {

                    List<List<string>> Souce = Export(LanguageFiles[i]);

                    if (Flags.HasFlag(Args.filter))
                    {
                        Souce = ApplyFilter(Souce);
                    }

                    Strings.Add(new List<string>() { "[~PATHFile~]", "[PATH]" + Souce.Count + "*" + Path.GetFullPath(LanguageFiles[i]).Replace(Path.GetFullPath(FolderPath), "") + "[PATH]", "[~PATHFile~]" });
                    Strings.AddRange(Souce);
                }
                catch (Exception EX)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(ConsoleText.Length, Console.CursorTop - 1);
                    Console.WriteLine("Fail");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("无法解析，将跳过此文件。\n" + EX.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(ConsoleText.Length, Console.CursorTop - 1);
                Console.WriteLine("Done");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        void EditList(List<List<string>> Strings, string[] StringValues)
        {

            if (Flags.HasFlag(Args.filter))
            {
                ApplyFilter(Strings, StringValues);
                return;
            }

            if (StringValues.Length < Strings.Count)
            {
                throw new Exception("文本文件太短");
            }
            for (int i = 0; i < StringValues.Length; i++)
            {
                try
                {
                    if (!Flags.HasFlag(Args.noname))
                    {
                        Strings[i][1] = StringValues[i].Split(new char[] { '=' }, 2)[1];
                    }
                    else
                    {
                        Strings[i][1] = StringValues[i];
                    }
                }
                catch
                {
                    throw new Exception("无法从文本文件解析此行： " + StringValues[i]);
                }

            }
        }



        private void Import(string FilePath, string[] Values, string Option)
        {

            if (!File.Exists(FilePath))
            {
                throw new Exception("文件不存在： " + FilePath);
            }

            if (FilePath.EndsWith(".locres", StringComparison.OrdinalIgnoreCase))
            {
                var locres = new LocresFile(FilePath);
                var strings = locres.ExtractTexts();
                EditList(strings, Values);
                locres.ImportTexts(strings);

                if (Option == "-import")
                {
                    locres.SaveFile(FilePath);
                    return;
                }

                FilePath = Path.ChangeExtension(FilePath, null) + "_NEW.locres";
                locres.SaveFile(FilePath);
            }
            else if (FilePath.EndsWith(".uasset", StringComparison.OrdinalIgnoreCase) || FilePath.EndsWith(".umap", StringComparison.OrdinalIgnoreCase))
            {
                IUasset Uasset = Uexp.GetUasset(FilePath);
                if (Flags.HasFlag(Args.method2))
                {
                    Uasset.UseMethod2 = true;
                }

                Uexp uexp = new Uexp(Uasset);
                EditList(uexp.Strings, Values);

                if (Option == "-import")
                {
                    uexp.SaveFile(FilePath);
                    return;
                }

                if (FilePath.EndsWith(".uasset", StringComparison.OrdinalIgnoreCase))
                {
                    FilePath = Path.ChangeExtension(FilePath, null) + "_NEW.uasset";
                }
                else if (FilePath.EndsWith(".umap", StringComparison.OrdinalIgnoreCase))
                {
                    FilePath = Path.ChangeExtension(FilePath, null) + "_NEW.umap";
                }

                uexp.SaveFile(FilePath);
            }
            else
            {
                throw new Exception("无效的语言文件类型： " + Path.GetFileName(FilePath));
            }

        }

        private void ImportFolder(string FolderPath, string[] Values, string Option)
        {

            if (!Directory.Exists(FolderPath))
            {
                throw new Exception("目录不存在：" + FolderPath);
            }


            int[] Indexs = Values.Select((Value, Index) => (Value.Trim().StartsWith("[PATH]") && Value.Trim().EndsWith("[PATH]")) ? Index : -1).Where(index => index != -1).ToArray();

            if (Indexs.Length == 0)
            {
                throw new Exception("源文本文件已损坏或不包含文本，或者你修改了语言文件路径([PATH]....[PATH]).");
            }

            for (int PathIndex = 0; PathIndex < Indexs.Length; PathIndex++)
            {
                string[] RecordInfo = Values[Indexs[PathIndex]].Replace("[PATH]", "").Trim().Split(new char[] { '*' }, 2);
                int ArraySize = int.Parse(RecordInfo[0]);
                string FilePath = RecordInfo[1];

                if (string.IsNullOrEmpty(FilePath))
                {
                    Console.WriteLine("无法从" + Indexs[PathIndex] + "行获取路径");
                    continue;
                }
                FilePath = FolderPath + @"\" + FilePath;
                FilePath = FilePath.Replace(@"\\", @"\");
                Console.ForegroundColor = ConsoleColor.Blue;
                string ConsoleText = $"[{PathIndex + 1}:{Indexs.Length}] Importing... '{Path.GetFileName(FilePath)}' ";
                Console.WriteLine(ConsoleText);
                Console.ForegroundColor = ConsoleColor.White;
                string[] StringArrayValues = new string[ArraySize];
                Array.Copy(Values, Indexs[PathIndex] + 1, StringArrayValues, 0, ArraySize);

                try
                {
                    if (Option == "importall")
                        Import(FilePath, StringArrayValues, "import");
                    else
                        Import(FilePath, StringArrayValues, "-import");
                }
                catch (Exception EX)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(ConsoleText.Length, Console.CursorTop - 1);
                    Console.WriteLine("Fail");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("无法解析，将跳过此文件。\n" + EX.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(ConsoleText.Length, Console.CursorTop - 1);
                Console.WriteLine("Done");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }


        private void GetFilterValues()
        {

            if (!File.Exists("FilterValues.txt"))
            {
                throw new Exception("没有找到 'FilterValues.txt' 文件, 打开UI从 (工具>筛选)创建文件");
            }

            try
            {
                List<string> FV = new List<string>();
                FV.AddRange(File.ReadAllLines("FilterValues.txt"));
                string[] Controls = FV[0].Split(new char[] { '|' });
                bool.TryParse(Controls[0], out UseMatching);
                bool.TryParse(Controls[1], out RegularExpression);
                bool.TryParse(Controls[2], out ReverseMode);
                FV.RemoveAt(0);
                ArrayValues = FV;
            }
            catch (Exception ex)
            {
                throw new Exception("无法解析 'FilterValues.txt', 打开UI从 (工具>筛选)创建一个新文件\n" + ex.Message);
            }
        }


        private List<List<string>> ApplyFilter(List<List<string>> Strings)
        {
            List<List<string>> FV = new List<List<string>>();
            for (int x = 0; x < Strings.Count; x++)
            {

                bool CanAdd = false;


                ArrayValues.ForEach(Value =>
                  {

                      if (UseMatching)
                      {
                          if (RegularExpression)
                          {
                              try
                              {
                                  if (Regex.IsMatch(Strings[x][0], Value))
                                  {
                                      CanAdd = true;
                                  }

                              }
                              catch { }
                          }
                          else
                          {
                              if (Strings[x][0] == Value)
                              {
                                  CanAdd = true;
                              }
                          }
                      }
                      else
                      {
                          if (RegularExpression)
                          {
                              try
                              {
                                  if (Regex.IsMatch(Strings[x][0], Value, RegexOptions.IgnoreCase))
                                  {
                                      CanAdd = true;
                                  }
                              }
                              catch { }
                          }
                          else
                          {
                              if (Strings[x][0].IndexOf(Value, StringComparison.OrdinalIgnoreCase) >= 0)
                              {
                                  CanAdd = true;
                              }
                          }
                      }
                  });

                if (CanAdd)
                {
                    if (!ReverseMode)
                        FV.Add(Strings[x]);
                }
                else if (ReverseMode)
                {
                    FV.Add(Strings[x]);
                }
            }
            return FV;
        }


        private void ApplyFilter(List<List<string>> Strings, string[] Array)
        {
            int i = 0;
            for (int x = 0; x < Strings.Count; x++)
            {

                bool CanAdd = false;


                ArrayValues.ForEach(Value =>
                {

                    if (UseMatching)
                    {
                        if (RegularExpression)
                        {
                            try
                            {
                                if (Regex.IsMatch(Strings[x][0], Value))
                                {
                                    CanAdd = true;
                                }

                            }
                            catch { }
                        }
                        else
                        {
                            if (Strings[x][0] == Value)
                            {
                                CanAdd = true;
                            }
                        }
                    }
                    else
                    {
                        if (RegularExpression)
                        {
                            try
                            {
                                if (Regex.IsMatch(Strings[x][0], Value, RegexOptions.IgnoreCase))
                                {
                                    CanAdd = true;
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            if (Strings[x][0].IndexOf(Value, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                CanAdd = true;
                            }
                        }
                    }
                });

                if (CanAdd)
                {
                    if (!ReverseMode)
                    {

                        try
                        {
                            if (!Flags.HasFlag(Args.noname))
                            {
                                Strings[x][1] = Array[i].Split(new char[] { '=' }, 2)[1];
                                i++;
                            }
                            else
                            {
                                Strings[x][1] = Array[i];
                                i++;
                            }
                        }
                        catch
                        {
                            throw new Exception("无法从文本文件解析此行： " + Array[i]);
                        }
                    }
                }
                else if (ReverseMode)
                {
                    try
                    {
                        if (!Flags.HasFlag(Args.noname))
                        {
                            Strings[x][1] = Array[i].Split(new char[] { '=' }, 2)[1];
                            i++;
                        }
                        else
                        {
                            Strings[x][1] = Array[i];
                            i++;
                        }
                    }
                    catch
                    {
                        throw new Exception("无法从文本文件解析此行： " + Array[i]);
                    }
                }
            }
        }




    }

}

