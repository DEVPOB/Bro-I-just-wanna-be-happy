
using UnityEngine;

public class GuyInFrontOf_AI_Event : MonoBehaviour
{
    public GameObject GuyInForntOf_Ai;
    public Stat stat;
    public Quotes QuotesScript;
    public float TimeRemainingToCloseLight = 7f;
    [SerializeField]private bool HasDestroy = false;
    void Update()
    {
        if(GameObject.Find("GuyInFrontOfDoor_Ai(Clone)") != null)
        {
            TimeRemainingToCloseLight = TimeRemainingToCloseLight - Time.deltaTime;
            if(TimeRemainingToCloseLight <= 0)
            {
                Destroy(GameObject.Find("GuyInFrontOfDoor_Ai(Clone)"));
                stat.MainSpotLight.SetActive(false);
                HasDestroy = true;
                stat.NeedLightFix = true;
                TimeRemainingToCloseLight = 7f;

            }
            
            if(QuotesScript.AlreadySaid == true)
            {
                Destroy(GameObject.Find("GuyInFrontOfDoor_Ai(Clone)"));
                HasDestroy = true;
                TimeRemainingToCloseLight = 7f;
            }
        }
        if(HasDestroy == true)
        {
            FindObjectOfType<SFXManager>().Play("AI_GONE");
            HasDestroy = false;
        }
    }
}
