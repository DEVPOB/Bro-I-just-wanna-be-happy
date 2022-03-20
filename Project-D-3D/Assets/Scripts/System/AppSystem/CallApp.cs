using UnityEngine;
using TMPro;

public class CallApp : MonoBehaviour
{
    [SerializeField] Phone_App Phone;
    [SerializeField] Animator Anim;
    [SerializeField] GameObject CallingUI;
    [SerializeField] TextMeshProUGUI CallingTo_Text;
    [SerializeField] TextMeshProUGUI TextCallingSuccess, TextCallingFail;
    public Quotes QuotesScript;
    public Stat stat;

    private float CallingTime = 3f;
    [SerializeField]private float CoolDownTime = 6f;
    public bool CallingSuccess = false;
    public bool CallingCoach = false;
    public bool CallingToilet_Helper = false;
    public bool CanKillNormalFriend = false;
    public bool CanCall = true;
    void Update()
    {
        if (Phone.onapp == false)
        {
            gameObject.SetActive(false);
            CoolDownTime = 6f;
            CanCall = true;
        }
        if (CallingUI.activeInHierarchy == true)
        {
            CallingTime = CallingTime - Time.deltaTime;
            if (CallingTime <= 0)
            {

                Anim.Play("CallingSuccess");
                CallingSuccess = true;
                CallingUI.SetActive(false);
                CallingTime = 3f;
                if(CallingCoach == true)
                {
                    QuotesScript.Start();
                    QuotesScript.fullText = "When i was five,Yes i was five";
                    stat.sanity += 5f;
                    CallingCoach = false;
                }
                if(CallingToilet_Helper == true)
                {
                    CanKillNormalFriend = true;
                    CallingToilet_Helper = false;
                }
              
            }

        }
        if(CanCall == false)
        {
            CoolDownTime = CoolDownTime - Time.deltaTime;
            if(CoolDownTime <= 0)
            {
                CanCall = true;
                CoolDownTime = 6f;
            }
        }
        
    }
   
    public void Life_CoachCalling()
    {
        if(CanCall == false)
        {
            return;
        }
        FindObjectOfType<SFXManager>().Play("CallSFX");
        CallingCoach = true;
        CallingUI.SetActive(true);
        CallingTo_Text.text = "Life Coach";
        CanCall = false; 
        
    }
    public void ToiletHelperCalling()
    {
        if(CanCall == false)
        {
            return;
        }
        FindObjectOfType<SFXManager>().Play("CallSFX");
        CallingToilet_Helper = true;
        CallingUI.SetActive(true);
        CallingTo_Text.text = "Toilet Helper";
        CanCall = false;
    }
    public void CancelBtn()
    {
        FindObjectOfType<SFXManager>().Play("ExitSFX");
        FindObjectOfType<SFXManager>().Stop("CallSFX");
        CallingUI.SetActive(false);
        CallingTime = 3f;
        Anim.Play("CallingFail");
    }
   
}
