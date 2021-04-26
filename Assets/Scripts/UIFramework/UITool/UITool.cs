using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// UI������ ������ȡĳ���Ӷ�������Ĳ���
/// </summary>
public class UITool
{
    /// <summary>
    /// ��ǰ����
    /// </summary>
    GameObject activePanel;

    public UITool(GameObject panel)
    {
        activePanel = panel;
    }

    /// <summary>
    /// ����ǰ�Ļ����ȡ�����һ�����
    /// </summary>
    /// <typeparam name="T">type of component</typeparam>
    /// <returns></returns>
    public T GetOrAddComponent<T>() where T : Component
    {
        if (activePanel.GetComponent<T>() == null)
        {
            activePanel.AddComponent<T>();
        }
        return activePanel.GetComponent<T>();
    }

    /// <summary>
    /// search a child object in active panel
    /// </summary>
    /// <param name="name">child object's name</param>
    /// <returns></returns>
    public GameObject FindChildGameObject(string name)
    {
        Transform[] trans = activePanel.GetComponentsInChildren<Transform>();
 
        foreach(Transform t in trans)
        {
            if (t.name.Equals(name))
            {
                return t.gameObject;
            }
        }

        Debug.LogWarning("we can't find any child,please check the input name");
        return null;
    }

    /// <summary>
    /// get or add component to a child according to its name
    /// </summary>
    /// <typeparam name="T">type of component</typeparam>
    /// <param name="name">child object's name</param>
    /// <returns></returns>
    public T GetorAddComponentInChildren<T>(string name) where T : Component
    {

        GameObject child = FindChildGameObject(name);
        if (child != null)
        {
            if (child.GetComponent<T>() == null)
            {
                child.AddComponent<T>();
            }
            return child.GetComponent<T>();
        }
        return null;
    }
}
