using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_App : MonoBehaviour
{
    public GameObject CCTV_Manager;
    public Animator Anim;
    public bool onanimation = false;
    public void Cam()
    {
        Anim.Play("CCTVAppTransition");
        onanimation = true;
        StartCoroutine(WaitForAnimation(Anim.GetCurrentAnimatorStateInfo(0).length));
        print("TEST");
    }
    IEnumerator WaitForAnimation(float _delay =0)
    {
        yield return new WaitForSeconds(_delay=.3f);
        onanimation = false;
        CCTV_Manager.GetComponent<CCTV>().enabled = true;
    }
}
