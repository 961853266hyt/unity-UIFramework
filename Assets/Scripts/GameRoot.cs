using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 全局管理
/// </summary>
public class GameRoot : MonoBehaviour
{
    /// <summary>
    /// gameroot 类的一个单例
    /// </summary>
    public static GameRoot instance { get; private set; }
    /// <summary>
    /// 场景管理器
    /// </summary>
    public SceneSystem sceneSystem { get; private set; }

    private void Awake()
    {
        instance = this;
        sceneSystem = new SceneSystem();
    }

    // Start is called before the first frame update
    void Start()
    {
        sceneSystem.SetScene(new StartScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
