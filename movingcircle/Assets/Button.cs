using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    KeyCode key;
   
    void Start()
    {
        //getting the appropriate KeyCode from Button text to make the script more universal
        this.key=(KeyCode)Enum.Parse(typeof(KeyCode), this.GetComponentInChildren<Text>().text);
    }
    
    public void OnPointerDown(PointerEventData data)
    {   
        //simulating keyboard button down
        InputCtrl.ForcedKeys.Add(this.key);
    }

    public void OnPointerUp(PointerEventData data)
    {
        //simulating keyboard button up
        InputCtrl.ForcedKeys.Remove(this.key);
    }

}
