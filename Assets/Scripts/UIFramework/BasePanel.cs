using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI���Ļ���
/// </summary>
public abstract class BasePanel
{
    public UIType UIType { get; private set;}
    public UITool UITool { get; private set; }

    public PanelManager panelManager { get; private set; }

    public UIManager uIManager { get; private set; }
    public BasePanel(UIType uIType)
    {
        UIType = uIType;
    }

    public void initPanelManager(PanelManager p)
    {
        panelManager = p;
    }

    public void initUIManager(UIManager u)
    {
        uIManager = u;
    }

    /// <summary>
    /// initialize the UItool
    /// </summary>
    /// <param name="uItool"></param>
    public void initUITool(UITool uItool)
    {

        UITool = uItool;

    }

    /// <summary>
    /// ��ʼ������
    /// </summary>
    public virtual void OnEnter()
    
    { 
    
    
    }
    /// <summary>
    /// UI��ͣʱִ�еĲ��� 
    /// </summary>
    public virtual void OnPause()
    {
        UITool.GetOrAddComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public virtual void OnResume()
    {
        UITool.GetOrAddComponent<CanvasGroup>().blocksRaycasts = true;

    }


    public virtual void OnExit()
    {
        uIManager.DestroyUI(UIType);
    }

    
}
