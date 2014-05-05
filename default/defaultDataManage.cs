using UnityEngine;
using System.Collections;

public class defaultDataManageclass{

    private static readonly object lockHelper = new object();
    private defaultDataManageclass(){}
	public static defaultCsvDataParent Instance(string className)
	{
        lock(lockHelper)
        {
			//start
			return null;
		}
		return null;
    }
}