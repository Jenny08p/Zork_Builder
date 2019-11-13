using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork_Common;
using TMPro;
using System;

public class UniyInputService : MonoBehaviour, IInputService
{
    public TMP_InputField InputField;

    public event EventHandler<string> InputReceived;

    public void ProcessInput()
    {
        InputReceived?.Invoke(this, InputField.text);
    }
}
