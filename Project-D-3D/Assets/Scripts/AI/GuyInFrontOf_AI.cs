
using UnityEngine;

public class GuyInFrontOf_AI : MonoBehaviour
{
    public GameObject GuyInForntOf_Ai;
    public Stat stat;
    public Quotes QuotesScript;
    public float TimeRemainingToCloseLight = 7f;

    void Update()
    {
        if(GameObject.Find("GuyInFrontOfDoor_Ai(Clone)") != null)
        {
            TimeRemainingToCloseLight = TimeRemainingToCloseLight - Time.deltaTime;
            if(TimeRemainingToCloseLight <= 0)
            {
                Destroy(GameObject.Find("GuyInFrontOfDoor_Ai(Clone)"));
                stat.MainSpotLight.SetActive(false);
                stat.NeedLightFix = true;
                TimeRemainingToCloseLight = 7f;
            }
            
            if(QuotesScript.AlreadySaid == true)
            {
                Destroy(GameObject.Find("GuyInFrontOfDoor_Ai(Clone)"));
                QuotesScript.AlreadySaid = false;
                TimeRemainingToCloseLight = 7f;
            }
            

        }
    }
}
