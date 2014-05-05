Unity-CSV-To-C-Sharp
====================

Unity CSV转为C#文件 来省去解析csv的步骤，节省游戏加载时间。

用法：

	把csv文件放到csv_folder文件夹中，运行_ExcelToCSharp.py这个python脚本即可。然后C#文件会出现在csharp_folder中，然后可以直接使用。
	
注意：

	csv文件第一行是中文注释，第二行英文注释（也是获取数据的key值）
	如下：
	
	---------------------
	名字	        对应文件名
	name	    csvname
	wangming	HeroData1
	xiaohong	HeroData2
	---------------------
