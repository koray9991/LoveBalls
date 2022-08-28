using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class buton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool uzerinde;
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        uzerinde = false;
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        uzerinde = true;
    }

}

