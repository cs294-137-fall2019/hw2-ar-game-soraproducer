using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 
public class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool Pressed = false;
 
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }
 
    public void OnPointerEnter(PointerEventData eventData)
    {
        Pressed = true;
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        Pressed = false;
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
