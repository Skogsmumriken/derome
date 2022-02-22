using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject obj;

    //V�xla mellan aktiv/inaktiv.
    public void toggleActive()
    {
        obj.SetActive(!obj.activeInHierarchy);
    }

}
