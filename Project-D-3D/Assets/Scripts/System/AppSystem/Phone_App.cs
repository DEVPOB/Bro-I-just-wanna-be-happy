
using UnityEngine;

public class Phone_App : MonoBehaviour
{
    public GameObject CCTV_Manager;
    public Animator Anim;
    public GameObject RecoveryApp,StatApp,CallApp;
    [SerializeField] Stat stat;
    public GameObject GuideApp, Page1;
    public bool onapp = false;
    
    public void Cam()
    {
        if(stat.NeedWifiFix)
        {
            return;
        }
        FindObjectOfType<SFXManager>().Play("SelectSFX");
        Anim.Play("CCTVAppTransition");
        onapp = true;
        CCTV_Manager.GetComponent<CCTV>().cam[0].SetActive(true);

    }
    public void Recovery()
    {

        FindObjectOfType<SFXManager>().Play("SelectSFX");
        Anim.Play("RecoveryTransitionOpen");
        RecoveryApp.SetActive(true);
        onapp = true;
    }
    public void Guide()
    {
        FindObjectOfType<SFXManager>().Play("SelectSFX");
        Anim.Play("GuideAppOpen");
        GuideApp.SetActive(true);
        Page1.SetActive(true);
        onapp = true;
    }
    public void Call()
    {
        FindObjectOfType<SFXManager>().Play("SelectSFX");
        Anim.Play("CALLOpen");
        CallApp.SetActive(true);
        onapp = true;
    }
    public void Stat()
    {
        FindObjectOfType<SFXManager>().Play("SelectSFX");
        Anim.Play("StatOpen");
        StatApp.SetActive(true);
        onapp = true;
    }
    public void Home()
    {
        FindObjectOfType<SFXManager>().Play("ExitSFX");
        Anim.Play("StatClose");
        onapp = false;
    }
}
