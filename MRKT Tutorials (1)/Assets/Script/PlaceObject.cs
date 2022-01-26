using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit;

// Flytta pointer mot golvet (peka) och klicka,
// för att placera GameObject (tempCube) ovanför pointer.
// Samtliga metoder behövs för att scriptet ska funka, men alla används inte nu.
// /Madde

public class PlaceObject : MonoBehaviour, IMixedRealityPointerHandler
{
    public GameObject tempCube;

    private void OnEnable()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityPointerHandler>(this);
    }
    private void OnDisable()
    {
        CoreServices.InputSystem?.UnregisterHandler<IMixedRealityPointerHandler>(this);
    }

    // OnPointerClicked: när man pekar på golvet hämtas
    // pointerns (cursor) position och skickas till OnPointerEnter.
    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        var result = eventData.Pointer.Result;
        var spawnPosition = result.Details.Point;
        OnPointerEnter(spawnPosition);
    }

    // OnPointerEnter: GameObjects position flyttas till pointerns position
    // och 89 cm läggs till på y-axeln.
    public void OnPointerEnter(Vector3 cursorPosition)
    {
        // Vector3(x,y,z)
        tempCube.transform.position = cursorPosition + new Vector3(0, 0.89f, 0);
    }

    // Dessa används inte, men behöver vara med för att scriptet ska funka.
    public void OnPointerDown(MixedRealityPointerEventData eventData) { }

    public void OnPointerUp(MixedRealityPointerEventData eventData) { }

    public void OnPointerDragged(MixedRealityPointerEventData eventData) { }

    public void OnPointerExit(MixedRealityPointerEventData eventData) { }
}
