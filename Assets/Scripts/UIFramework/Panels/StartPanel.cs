using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : BasePanel
{
    static readonly string path = "Prefabs/UI/Panel/StartPanel";

    public StartPanel() : base(new UIType(path))
    {
        

    }

    public override void OnEnter()
    {
        UITool.GetorAddComponentInChildren<Button>("StartButton").onClick.AddListener(() =>
        {
            //add the click event here
            //Debug.Log("开始按钮被点击了");
            GameRoot.instance.sceneSystem.SetScene(new Scene1());
        }
        );

        UITool.GetorAddComponentInChildren<Button>("SettingsButton").onClick.AddListener(() =>
        {
            panelManager.push(new SettingsPanel());
        }
        );
    }

   
    public override void OnPause()
    {
        base.OnPause();
    }

    public override void OnResume()
    {
        base.OnResume();
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
