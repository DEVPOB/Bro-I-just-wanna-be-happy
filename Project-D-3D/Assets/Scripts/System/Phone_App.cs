using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_App : MonoBehaviour
{

    public GameObject CCTV_Manager;
    public Animator Anim;
    public GameObject RecoveryApp;
    public GameObject GuideApp, Page1;
    public bool onapp = false;
    public void Cam()
    {
        Anim.Play("CCTVAppTransition");
        onapp = true;
        StartCoroutine(WaitForAnimation(Anim.GetCurrentAnimatorStateInfo(0).length));
    }
    public void Recovery()
    {

        Anim.Play("RecoveryTransitionOpen");
        RecoveryApp.SetActive(true);
        onapp = true;
    }
    public void Guide()
    {
        Anim.Play("GuideAppOpen");
        GuideApp.SetActive(true);
        Page1.SetActive(true);
        onapp = true;
    }
    public void Call()
    {
        Anim.Play("CALLOpen");
        onapp = true;
    }
    public void Stat()
    {
        Anim.Play("StatOpen");
        onapp = true;
    }
    public void Home()
    {
        Anim.Play("StatClose");
        onapp = false;
    }
    IEnumerator WaitForAnimation(float _delay =0)
    {
        yield return new WaitForSeconds(_delay=.3f);
        CCTV_Manager.GetComponent<CCTV>().cam[0].SetActive(true);
        
    }
}
