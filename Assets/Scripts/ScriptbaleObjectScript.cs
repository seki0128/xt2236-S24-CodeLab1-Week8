using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[
    CreateAssetMenu(fileName = "New Object", menuName = "New Object", order = 0)
]
public class ScriptbaleObjectScript : ScriptableObject
{
    public string ObjectContent;
    public Color textColor;

    public ScriptbaleObjectScript nextText_A;
    public ScriptbaleObjectScript nextText_B;

    public void ShowContent()
    {
        
    }
}
