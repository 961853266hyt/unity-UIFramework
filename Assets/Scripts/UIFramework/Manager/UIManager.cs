using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 存储所有UI信息，并可以创建或销毁UI
/// </summary>
public class UIManager
{
    private Dictionary<UIType, GameObject> dicUI;


    public UIManager()
    {
        dicUI = new Dictionary<UIType, GameObject>();
    }

    /// <summary>
    /// 获取一个UI对象
    /// </summary>
    /// <param name="uIType">UI信息</param>
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
    /// 销毁一个UI对象
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
