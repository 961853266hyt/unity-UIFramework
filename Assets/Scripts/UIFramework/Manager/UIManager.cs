using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �洢����UI��Ϣ�������Դ���������UI
/// </summary>
public class UIManager
{
    private Dictionary<UIType, GameObject> dicUI;


    public UIManager()
    {
        dicUI = new Dictionary<UIType, GameObject>();
    }

    /// <summary>
    /// ��ȡһ��UI����
    /// </summary>
    /// <param name="uIType">UI��Ϣ</param>
    /// <returns></returns>
    public GameObject GetSingleUI(UIType uIType)
    {
        GameObject parent = GameObject.Find("Canvas");
        if (!parent)
        {
            Debug.LogError("canvas does not exist");
            return null;
        }
        if (dicUI.ContainsKey(uIType))
            return dicUI[uIType];
        GameObject ui = GameObject.Instantiate(Resources.Load<GameObject>(uIType.Path), parent.transform);
        ui.name = uIType.Name;
        dicUI.Add(uIType,ui);
        return ui;
    }

    /// <summary>
    /// ����һ��UI����
    /// </summary>
    /// <param name="uIType">UI info</param>
    public void DestroyUI(UIType uIType)
    {
        if (dicUI.ContainsKey(uIType))
        {
            GameObject.Destroy(dicUI[uIType]);
            dicUI.Remove(uIType);
        }
    }
}
