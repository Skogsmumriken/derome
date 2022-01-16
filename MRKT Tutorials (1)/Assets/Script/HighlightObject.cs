using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    public GameObject model;

    void Start()
    {
        model.SetActive(false);
    }

    public void highlightUpperPlate()
    {
        model.SetActive(!model.activeInHierarchy);
    }

    public void highlightLowerPlate()
    {
        model.SetActive(!model.activeInHierarchy);
    }

    public void highlightWood()
    {
        model.SetActive(!model.activeInHierarchy);
    }
}
