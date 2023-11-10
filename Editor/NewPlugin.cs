using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UpmTest : Editor
{
    [MenuItem("Tools/测试newPlugin", false, 0)]
    public static void Test()
    {
        Debug.Log("测试输出newPlugin");
    }
}
