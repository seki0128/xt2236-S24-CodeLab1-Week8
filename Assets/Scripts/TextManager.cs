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

    private void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (textContent.nextText_A != null)
            {
                textContent = textContent.nextText_A;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        else if(Input.GetMouseButtonDown(0))
        {
            if (textContent.nextText_B != null)
            {
                textContent = textContent.nextText_B;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

    }
}
