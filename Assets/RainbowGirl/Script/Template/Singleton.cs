using UnityEngine;
using System.Collections;

public class Singleton<T> where T : new()
{
    static private T sInstance;
    static public T GetSingleton()
    {
        if(sInstance == null)
        {
            LogManager.LogErrorFormat("not create instance:{0}", typeof(T).ToString());
        }

        return sInstance;
    }

    static public void CreateInstance()
    {
        if (sInstance == null)
        {
            sInstance = new T();
        }
        else
        {
            LogManager.LogErrorFormat("already create instance:{0}", typeof(T).ToString());
        }
    }
}
