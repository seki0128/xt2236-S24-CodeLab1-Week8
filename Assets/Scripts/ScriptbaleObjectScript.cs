using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[
    CreateAssetMenu(fileName = "New Object", menuName = "New Object", order = 0)
]
public class ScriptbaleObjectScript : ScriptableObject
{
    public string ObjectName;
    public string ObjectDesc;

    public bool isPickUp;

    public void PickUpObject()
    {
        if (!isPickUp)
        {
            isPickUp = true;
        }
    }
}
