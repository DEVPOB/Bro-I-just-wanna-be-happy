using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_App : MonoBehaviour
{
    public GameObject CCTV_Manager;
    public Animator Anim;
    public bool onapp = false;
    public void Cam()
    {
        Anim.Play("CCTVAppTransition");
        onapp = true;
        StartCoroutine(WaitForAnimation(Anim.GetCurrentAnimatorStateInfo(0).length));
        print("TEST");
    }
    public void Recovery()
    {
        Anim.Play("RecoveryTransitionOpen");
        onapp = true;
        print("TEST");
    }
    public void Guide()
    {
        Anim.Play("GuideAppOpen");
        onapp = true;
        print("TEST");
    }
    public void Call()
    {
        Anim.Play("CALLOpen");
        onapp = true;
        print("TEST");
    }
    public void Stat()
    {
        Anim.Play("StatOpen");
        onapp = true;
        print("TEST");
    }
    IEnumerator WaitForAnimation(float _delay =0)
    {
        yield return new WaitForSeconds(_delay=.3f);
        CCTV_Manager.GetComponent<CCTV>().cam[0].SetActive(true);
        
    }
}
