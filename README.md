Unity-CSV-To-C-Sharp
====================

Unity CSV转为C#文件 来省去解析csv的步骤，节省游戏加载时间。

环境要求：

	安装Python环境
	Windows 需要配置环境变量，然后直接双击python脚本即可运行。
	Mac安装Python后在终端直接 python _ExcelToCSharp.py的绝对路径即可
转换：

	把csv文件放到csv_folder文件夹中，运行_ExcelToCSharp.py这个python脚本即可。然后C#文件会出现在csharp_folder/data中，
	然后可以直接使用。

注意：

	csv文件第一行是中文注释，第二行英文注释（也是获取数据的key值）
	如下：
	
	-----HeroManage.csv------
	名字	        对应文件名
	name	        csvname
	wangming	HeroData1
	xiaohong	HeroData2
	---------------------
	
	----- HeroData1.csv ------
	等级	血量	魔法
	level	hp	mp
	1	20	20
	2	30	30
	3	40	30
	4	40	40
	5	50	40
	---------------------
	
	----- HeroData2.csv ------
	等级	血量	魔法
	level	hp	mp
	1	10	10
	2	20	30
	3	30	30
	4	50	40
	5	90	100
	---------------------

调用：

	下载项目后，我里面有个例子 csharp_folder/data文件夹下有通过脚本把 csv_folder 目录下的csv转C#后的3个文件。
	
	分别是HeroData1.cs 、HeroData2.cs 、 HeroManage.cs
	
	如何调用HeroData1的数据，我们先看下提供了那几个方法：
	
	---常用---
	Instance()                                    单例模式，返回数据类实例对象。
	void print()       			      打印函数
	string[] getKeyArray();			      以一维数组的形式获取所有的key
	string get(int num,string typeName);	      通过第几行数据+key值获取string类型数据
	int getInt(int num,string typeName);	      通过第几行数据+key值获取int类型数据
	float getFloat(int num,string typeName);      通过第几行数据+key值获取float类型数据
	
	---偶尔---
	string[,] getDataArray();                     以二维数组的形式获取所有的数据
	int num();				      有多少行数据
	int keynum();				      有多少个key值
	
	
实际运用：

	文件名直接调用：
	
	Debug.Log( HeroData1.Instance().getInt(0,"level") )
	--0
	Debug.Log( HeroData1.Instance().getInt(4,"level") )
	--5
	Debug.Log( HeroData1.Instance().getInt(1,"hp") )
	--20
	
进击:

	通过dataManage类+字符串文件名直接调用方法
	
	//HeroData1中hp第二行数据的的第一种调用方法：
	Debug.Log( HeroData1.Instance().getInt(1,"hp") )
	--20
	
	//HeroData1中hp第二行数据的第二种调用方法：
        Debug.Log( dataManage.Instance("HeroData1").getInt(1,"hp") )
	--20


