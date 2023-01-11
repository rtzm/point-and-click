using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : Interactable
{
    public Item myItem;
    //bool itemPresent could be used if we want the item to vanish
    public override void Interact()
    {
        GameManager.ins.itemHeld = myItem;
        GameManager.ins.invDisp.UpdateDisplay();
    }
    
}
