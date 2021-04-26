using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������� ��ջ������UI
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
    /// UI��ջ�������˲�������ʾһ�����
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
    /// ִ�����ĳ�ջ����
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
