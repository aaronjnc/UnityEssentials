using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour
{
    [Tooltip("Text component")]
    private Text text;
    
    /// <summary>
    /// Called on Start (which is after Awake, and OnEnable)
    /// </summary>
    private void Start()
    {
        text = GetComponent<Text>();
        text.text = GameManager.Instance?.GetNumber() + "";
    }
}
