using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingManager : MonoBehaviour
{
    public GameObject MainSpotLight,Cam1Spotlight,Cam2Spotlight;
    private float random;
    private float lastrandom;
    void Update()
    {
        something();
    }
    
    void something()
    {
        if(random == 1)
        {
            Cam1Spotlight.SetActive(true);
            Cam2Spotlight.SetActive(false);
        }
        else
        {
            Cam1Spotlight.SetActive(false);
            Cam2Spotlight.SetActive(true);
        }
    }
  
}
