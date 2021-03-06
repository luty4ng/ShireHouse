using UnityEngine;
using System.Collections.Generic;
using GameKit;
using LitJson;
[System.Serializable]
public class CustomObj
{
    public int a = 1;
    public string b = "string";
}

public class Test : MonoBehaviour
{
    public List<CustomObj> listObjs = new List<CustomObj>();
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        listObjs.Add(new CustomObj());
        listObjs.Add(new CustomObj());
        listObjs.Add(new CustomObj());
        CustomObj obj = new CustomObj();
        SerializeManager.instance.SaveJson<List<CustomObj>>("Test.json", listObjs);
        // Debug.Log(JsonMapper.ToJson(obj));
    }
}