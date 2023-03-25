using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

     // Reference to the flashlight object
    public GameObject flashlight;

    // Toggle the flashlight when the F key is pressed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.SetActive(!flashlight.activeSelf);
        }
    }
}
