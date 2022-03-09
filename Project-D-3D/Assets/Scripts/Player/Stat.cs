
using UnityEngine;

public class Stat : MonoBehaviour
{
    public GameObject MainSpotLight;
    public float sanity = 100f;
    public bool dead = false;
    public bool NeedWifiFix = false;
    public bool NeedLightFix = false;

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
                * TODO : Non
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
