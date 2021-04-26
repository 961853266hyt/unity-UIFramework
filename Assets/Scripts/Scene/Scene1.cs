using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 第一个实验场景的管理
/// </summary>
public class Scene1 : BaseSceneState
{

    readonly string sceneName = "Scene1";
    private PanelManager panelManager;
    public override void OnEnter()
    {
        panelManager = new PanelManager();

        if (SceneManager.GetActiveScene().name != sceneName)
        {
            SceneManager.LoadScene(sceneName);
            SceneManager.sceneLoaded += SceneLoaded;
        }
        else
        {
            //panelManager.push(new StartPanel());
        }
    }

    public override void OnExit()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
    }

    private void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
       // panelManager.push(new StartPanel());
        Debug.Log($"{sceneName} has been loaded!");

    }
}
