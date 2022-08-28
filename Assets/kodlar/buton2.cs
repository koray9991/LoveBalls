using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class buton2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool uzerinde2;
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        uzerinde2 = false;
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        uzerinde2 = true;
    }

}

