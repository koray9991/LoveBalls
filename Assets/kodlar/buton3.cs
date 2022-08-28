using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class buton3 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool uzerinde3;
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        uzerinde3 = false;
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        uzerinde3 = true;
    }

}

