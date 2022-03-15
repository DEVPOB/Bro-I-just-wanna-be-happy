
using UnityEngine;

public class Stat : MonoBehaviour
{
    public GameObject MainSpotLight;
    public float sanity = 20f;
    public bool dead = false;
    public bool NeedWifiFix = false;
    public bool NeedLightFix = false;
    


    void Update()
    {
        if(sanity <= 0f)
        {
            dead = true;
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
