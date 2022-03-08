using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyInFrontOf_AI : MonoBehaviour
{
    public GameObject GuyInForntOf_Ai;
    public Stat stat;
    public Quotes QuotesScript;
    private float TimeRemainingToCloseLight = 7f;

    void Update()
    {
        if(GuyInForntOf_Ai != null)
        {
            TimeRemainingToCloseLight = TimeRemainingToCloseLight - Time.deltaTime;
            if(TimeRemainingToCloseLight <= 0)
            {
                stat.MainSpotLight.SetActive(false);
                stat.NeedLightFix = true;
            }
            if(TimeRemainingToCloseLight <= 0)
            {

            }

            if(QuotesScript.AlreadySaid == true)
            {
                Destroy(GuyInForntOf_Ai.gameObject);
                QuotesScript.AlreadySaid = false;
            }
            else
            {
                stat.dead = true;
            }

        }
    }
}
