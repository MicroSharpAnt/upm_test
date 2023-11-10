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

    // 测试证明，只有此分支有更新，点击update就会拉取代码，无需更改package.json
    [MenuItem("Tools/测试4", false, 0)]
    public static void Test4()
    {
        Debug.Log("测试输出4");
    }

    [MenuItem("Tools/Plugin测试1", false, 0)]
    public static void Plugin2Test1()
    {
        Debug.Log("这是插件分支的新增方法");
    }
}
