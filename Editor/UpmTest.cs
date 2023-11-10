using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UpmTest : Editor
{
    [MenuItem("Tools/测试", false, 0)]
    public static void Test1()
    {
        Debug.Log("测试输出1");
    }

    [MenuItem("Tools/测试2", false, 0)]
    public static void Test2()
    {
        Debug.Log("测试输出2");
    }
    
    [MenuItem("Tools/测试3", false, 0)]
    public static void Test3()
    {
        Debug.Log("测试输出3");
    }

    [MenuItem("Tools/测试4", false, 0)]
    public static void Test4()
    {
        Debug.Log("测试输出4");
    }
}
