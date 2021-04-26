using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// management of the start scene
/// </summary>
public class StartScene : BaseSceneState
{

    readonly string sceneName = "Start";
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
            panelManager.push(new StartPanel());
        }
    }

    public override void OnExit()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
    }

    private void SceneLoaded(Scene scene,LoadSceneMode mode)
    {
        panelManager.push(new StartPanel());
        Debug.Log($"{sceneName} has been loaded!");

    }
}
