using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float movementSpeed;
    public int cycles;
    public bool trigger = false;
    private int counter = 0; 
    public bool switcher = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (trigger == true)
        {
            if (switcher == true)
            {
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
                counter = counter + 1;
                if (counter == cycles)
                {
                    switcher = false;
                    counter = 0;
                }
            }
            else
            {
                transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
                counter = counter + 1;
                if (counter == cycles)
                {
                    switcher = true;
                    counter = 0;
                }
            }
        }
    }
}
