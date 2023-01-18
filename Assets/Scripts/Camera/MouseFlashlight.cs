using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFlashlight : MonoBehaviour
{
    Transform lightTransform;

    void Start()
    {
        lightTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(10);
        lightTransform.LookAt(position);
    }
}
