using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    public float sanity = 100f;

    void Update()
    {
        if(sanity <= 0f)
        {
            print("Sanity < 0");
        }
        decreaseSanity();
    }
    void decreaseSanity()
    {
        
    }    
}
