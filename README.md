# UE4LocalizationsTool 中文版 
一个简单 UE4 （unreal engine 4） 文本文件的工具。

开发者： Amr Shaheen
链接：https://github.com/amrshaheen61/UE4LocalizationsTool/tree/master
<hr>

## 命令代码
### 单个文件导出:
```
UE4localizationsTool.exe  export <(Locres/Uasset/Umap) 文件路径>  <Options>

例:
UE4localizationsTool.exe export Actions.uasset
```
### 单个文件导入:
```
UE4localizationsTool.exe  import <(txt) 文件路径>  <Options>

例:
UE4localizationsTool.exe import Actions.uasset.txt
```
### 单个文件导入不生成重命名的新文件:
```
UE4localizationsTool.exe  -import <(txt) FilePath>  <Options>

例:
UE4localizationsTool.exe -import Actions.uasset.txt
```

### 从文件夹导出文件:
```
UE4localizationsTool.exe  exportall  <文件夹路径> <导出文本路径和名称> <Options>

例:
UE4localizationsTool.exe exportall Actions text.txt
```
### 文件夹导入:
```
UE4localizationsTool.exe  importall  <文件夹路径> <导出文本路径和名称>  <Options>

例:
UE4localizationsTool.exe importall Actions text.txt
```
### 文件夹导入不生成重命名的新文件:
```
UE4localizationsTool.exe  -importall  <Folder> <TxtFile>  <Options>

例:
UE4localizationsTool.exe -importall Actions text.txt
```

### Options: (导入时一定要和导出时的 options 设置一模一样)

#### UI设置筛选，添加筛选项，重新打开工具或者在生成的 FilterValues.txt 添加修改，一行一项: (仅适用于 name 列的筛选)
```
-f or -filter

例:
UE4localizationsTool.exe export Actions.uasset -filter
```

#### 不包含 name 列的导出:
```
-nn or -NoName

例:
UE4localizationsTool.exe export Actions.uasset -NoName
```
####  method 2 使用:(尝试在不使用ue4资产结构的情况下捕获文本（仅适用于uasset和umap）)
```
-m2 or -method2

例：
UE4localizationsTool.exe export Actions.uasset -method2
UE4localizationsTool.exe export Actions.uasset -method2 -NoName -filter
```
