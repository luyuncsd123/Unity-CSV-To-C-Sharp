using UnityEngine;
using System.Collections;

public class dataManage{

    private static readonly object lockHelper = new object();
    private dataManage(){}
	public static csvDataParent Instance(string className)
	{
        lock(lockHelper)
        {
			//start
			if(className=="HeroManage")
			{
				return HeroManage.Instance();
			}
			if(className=="HeroData2")
			{
				return HeroData2.Instance();
			}
			if(className=="HeroData1")
			{
				return HeroData1.Instance();
			}
			return null;
		}
		return null;
    }
}