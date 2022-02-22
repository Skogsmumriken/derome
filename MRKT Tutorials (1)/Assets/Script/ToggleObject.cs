using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject obj;

    //Växla mellan aktiv/inaktiv.
    public void toggleActive()
    {
        obj.SetActive(!obj.activeInHierarchy);
    }

}
