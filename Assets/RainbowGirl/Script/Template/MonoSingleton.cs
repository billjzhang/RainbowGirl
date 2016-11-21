using UnityEngine;
using System.Collections;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static private T sInstance;
    static public T GetSingleton()
    {
        if (sInstance == null)
        {
            LogManager.LogErrorFormat("not create monoinstance:{0}", typeof(T).ToString());
        }

        return sInstance;
    }

    static public void CreateInstance()
    {
        if (sInstance == null)
        {
            GameObject obj = new GameObject(typeof(T).ToString());
            sInstance = obj.AddComponent<T>();
        }
        else
        {
            LogManager.LogErrorFormat("already create monoinstance:{0}", typeof(T).ToString());
        }
    }
}
