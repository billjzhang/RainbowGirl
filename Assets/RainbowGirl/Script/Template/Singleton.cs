using UnityEngine;
using System.Collections;

public class Singleton<T> where T : new()
{
    static private T sInstance;
    static public T GetSingleton()
    {
        if(sInstance == null)
        {
            sInstance = new T();
        }

        return sInstance;
    }

}
