using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 面板管理器 用栈来管理UI
/// </summary>
public class PanelManager
{
    private Stack<BasePanel> PanelStack;
    private UIManager uIManager;
    private BasePanel panel;

    public PanelManager()
    {
        PanelStack = new Stack<BasePanel>();
        uIManager = new UIManager();
    }

    /// <summary>
    /// UI入栈操作，此操作会显示一个面板
    /// </summary>
    /// <param name="nextPanel"></param>
    public void push(BasePanel nextPanel)
    {
        if (PanelStack.Count > 0)
        {
            panel = PanelStack.Peek();
            panel.OnPause();
        }
        PanelStack.Push(nextPanel);
        GameObject _Panel = uIManager.GetSingleUI(nextPanel.UIType);
        nextPanel.initUITool(new UITool(_Panel));
        nextPanel.initPanelManager(this);
        nextPanel.initUIManager(uIManager);
        nextPanel.OnEnter();
    }


    /// <summary>
    /// 执行面板的出栈操作
    /// </summary>
    public void Pop()
    {
        if (PanelStack.Count > 0)
        {
            PanelStack.Pop().OnExit();
        }
        if (PanelStack.Count > 0)
        {
            //Debug.Log($"{ PanelStack.Peek().UIType.Name}panel resume");
            PanelStack.Peek().OnResume();
        }
    }




}
