# 数据签名 digital signature By LC
Rider开发.net / .net core  
Rider: The Cross-Platform .NET IDE from JetBrains  
Fast & powerful,cross platform .NET IDE
> https://www.jetbrains.com/rider/

首先开发环境安装：  
1：.NET Framework Developer pack  
2：.NET Core SDK  
Download .NET (Linux, macOS, and Windows)
> https://dotnet.microsoft.com/download

可以开发：  
ConsoleApplication  控制台应用
WindowsFormsAppDeskTopWindowsForms  桌面应用
WpfApplicationDeskTopWPFApp

区别:wpf application 与 forms application有啥别？  
winform是基于传统Win32的应用。  
wpf是从底层开始重新构造的一种Windows API。

一些备份，一些记录  
1:数据签名.csproj里和DigitalSignature.csproj里  
```
<TargetFrameworkVersion>4.8</TargetFrameworkVersion>
```  
可以设置或修改.NETFramework版本，为了解决一下bug
```
未找到框架“.NETFramework,Version=v4.5”的引用程序集。
若要解决此问题，请安装此框架版本的 SDK 或 Targeting Pack，
或将应用程序的目标重新指向已装有 SDK 或 Targeting Pack 的框架版本。
请注意，将从全局程序集缓存(GAC)解析程序集，并将使用这些程序集替换引用程序集。
因此，程序集的目标可能未正确指向您所预期的框架。
```

2：还有PluSoft.dll的引用相关
> C:\_developSoftKu\Rider-2019.2.2\CodeKu\数据签名-2018-11-5 171519 ok\PluSoft.dll
这里可以配置引用路径:
```
 <ItemGroup>
    <Reference Include="PluSoft">
      <HintPath>..\..\..\NB表具离散时间命令下发工具\Duizhang\bin\Debug\PluSoft.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
```
3:使用Rider进行桌面图形化开发时候也可以进行拖拽控件进行页面的布局  
内置了Designer Toolbox

4:编译，运行  
右上角的小锤子点击-build,即可编译。目录在如下:  
C:\_developSoftKu\Rider-2019.2.2\CodeKu\数据签名-2018-11-5 171519 ok\数据签名\bin\Debug  

C:\_developSoftKu\Rider-2019.2.2\CodeKu\数据签名-2018-11-5 171519 ok\数据签名\bin\Release

再右边可以进行运行的Default配置

再右边就是run/debug run

## About Me

**欢迎来到 [LC博客-一加壹博客最Top](http://www.oneplusone.vip)**

**欢迎来到 [LC-Gitlab](https://gitlab.com/ahviplc)**

**欢迎来到 [LC-Github](https://github.com/ahviplc)**

**欢迎来到 [LC-Github-digital_signature_by_rider](https://github.com/ahviplc/digital_signature_by_rider)**

> ### LC最寄语：永远不要放弃自己心中最初的最初的理想！~LC

> from **2019年9月4日12:21:30**

> to **future**
