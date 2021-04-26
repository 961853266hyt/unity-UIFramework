using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : BasePanel
{
    static readonly string path = "Prefabs/UI/Panel/SettingsPanel";

    public SettingsPanel() : base(new UIType(path))
    {


    }

    public override void OnEnter()
    {
        UITool.GetorAddComponentInChildren<Button>("BackButton").onClick.AddListener(() =>
        {

            //Debug.Log("退出按钮被点击了");
            panelManager.Pop();
        }
        );
    }
    public override void OnPause()
    {



    }


    public override void OnExit()
    {
        base.OnExit();
    }
}
