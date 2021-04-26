using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSceneState
{

    /// <summary>
    /// 场景进入时执行的操作
    /// </summary>
    public abstract void OnEnter();

    /// <summary>
    /// 场景退出时执行的操作
    /// </summary>
    public abstract void OnExit();

}
