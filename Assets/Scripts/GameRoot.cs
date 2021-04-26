using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ȫ�ֹ���
/// </summary>
public class GameRoot : MonoBehaviour
{
    /// <summary>
    /// gameroot ���һ������
    /// </summary>
    public static GameRoot instance { get; private set; }
    /// <summary>
    /// ����������
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
