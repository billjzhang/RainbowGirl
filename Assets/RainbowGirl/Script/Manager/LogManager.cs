using UnityEngine;
using System.Collections;

static public class LogManager
{
    static public void LogError(object msg)
    {
        Debug.LogError(msg);
    }

    static public void LogErrorFormat(string format, params object[] args)
    {
        Debug.LogErrorFormat(format, args);
    }

}
