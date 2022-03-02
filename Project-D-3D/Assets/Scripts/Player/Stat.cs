using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    public GameObject MainSpotLight;
    public float sanity = 100f;
    private bool dead = false;

    void Update()
    {
        if(sanity <= 0f)
        {
            /**
                * TODO : Do this after 3D model success
            **/
        }
        if(dead)
        {
            /**
                * TODO : Do this Tomorow
            **/
            
        }
        
    }
    void FixedUpdate()
    {
        decreaseSanity();
    }
    void decreaseSanity()
    {
        if(MainSpotLight.activeInHierarchy == false)
        {
            sanity = sanity - Time.deltaTime * 4;
        }
    }    
}
