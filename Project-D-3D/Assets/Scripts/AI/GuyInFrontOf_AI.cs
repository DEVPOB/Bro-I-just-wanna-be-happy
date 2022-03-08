using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyInFrontOf_AI : MonoBehaviour
{
    public GameObject GuyInForntOf_Ai;
    public Stat stat;
    public Quotes QuotesScript;

    void Update()
    {
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
