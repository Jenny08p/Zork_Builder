using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork_Common;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;

    [SerializeField]
    private Transform OutputTextContainer;

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {
        //throw new System.NotImplementedException();
        var textline = Instantiate(TextLinePrefab);
        textline.transform.SetParent(OutputTextContainer, false);
        textline.text = value;
    }

    public void WriteLine(object value)
    {
        throw new System.NotImplementedException();
    }
}
