using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSceneState
{

    /// <summary>
    /// ��������ʱִ�еĲ���
    /// </summary>
    public abstract void OnEnter();

    /// <summary>
    /// �����˳�ʱִ�еĲ���
    /// </summary>
    public abstract void OnExit();

}
