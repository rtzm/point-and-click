using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : Interactable
{
    //we want every switcher to start false
    public bool state;

    //event setup
    public delegate void OnStateChange();
    public event OnStateChange Change;

    public override void Interact()
    {
        state = !state;
        //if change is completely empty (nothing listening to is) you don't want to call change
        if (Change != null)
        {
            Change();
        }
    }
}
