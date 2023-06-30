using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clickdetector : MonoBehaviour, IPointerClickHandler
{
    public GameObject SettingsX;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the click event target is the panel itself
        if (eventData.pointerCurrentRaycast.gameObject == gameObject)
        {
            SettingsX.SetActive(false);
        }
    }
}