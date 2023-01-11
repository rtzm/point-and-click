using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite : MonoBehaviour
{
    //if true check for item instead
    public bool requireItem;
    public Switcher watchSwitcher;
    //if we want more than just one switch we'd want a public bool state we want
    //if requireItem is true we'll check this collector
    public Collector checkCollector;
    public bool nodeAccess;

    //check if prerequisit is met
    public bool Complete
    {
        //every switcher wants to start false then become true!!!
        get 
        {
            if (!requireItem)
            {
                return watchSwitcher.state;
            } 
            else
            {
                return GameManager.ins.itemHeld.itemName == checkCollector.myItem.itemName;
            }
        //get (return watchSwitcher.state == watchSwitcher.statewewant tutorial part 19 switcher events)
        }
    } 
}
