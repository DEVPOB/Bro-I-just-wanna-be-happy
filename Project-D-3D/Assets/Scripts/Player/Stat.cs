
using UnityEngine;

public class Stat : MonoBehaviour
{
    public GameObject MainSpotLight;
    public float sanity = 40f;
    public bool dead = false;
    public bool NeedWifiFix = false;
    public bool NeedLightFix = false;
    

    
    void Update()
    {

        if(sanity <= 0f)
        {
            dead = true;
        }
        else if(sanity > 40f)
        {
            sanity = 40f;
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
