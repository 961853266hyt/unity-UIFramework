using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ������״̬����ϵͳ
/// </summary>
public class SceneSystem
{
    

    BaseSceneState baseSceneState;

    /// <summary>
    /// ���õ�ǰ���������뵱ǰ����
    /// </summary>
    /// <param name="state"></param>
    public void SetScene(BaseSceneState state)
    {
        baseSceneState?.OnExit();
        baseSceneState = state;
        baseSceneState?.OnEnter();
    }
}
