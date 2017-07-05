using System.Collections.Generic;
using UnityEngine;

public class InputCtrl : MonoBehaviour {

    public static HashSet<KeyCode> ForcedKeys=new HashSet<KeyCode>();

    public static KeyCode SimKeyPress(KeyCode key)
    {
        if(Input.GetKey(key)||ForcedKeys.Contains(key))
            return key;
        
        return KeyCode.None;
    }


    public static bool  SimKeyPressBool(KeyCode key)
    {
        if (Input.GetKey(key) || ForcedKeys.Contains(key))
            return true;

        return false;
    }
}
