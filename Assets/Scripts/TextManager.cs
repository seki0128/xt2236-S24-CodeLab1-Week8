using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    private TextMeshPro text;
    public ScriptbaleObjectScript textContent;
    private void Awake()
    {
        text = GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        text.text = textContent.ObjectContent;
        text.color = textContent.textColor;
    }

    private void OnMouseUp()
    {
        if (textContent.nextText != null)
        {
            textContent = textContent.nextText;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
