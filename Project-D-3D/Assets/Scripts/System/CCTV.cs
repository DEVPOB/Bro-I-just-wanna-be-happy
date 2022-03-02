using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    public GameObject CCTV_Manager;

    public GameObject maincamera;
    [SerializeField]Phone_App Phone;
    public GameObject[] cam;
    private float lastput;
    public Animator CloseCCTV;


    public void SwitchToCam2()
    {
        maincamera.SetActive(false);
        cam[0].SetActive(false);
        cam[1].SetActive(true);
    }
    public void SwitchToCam1()
    {
        maincamera.SetActive(false);
        cam[1].SetActive(false);
        cam[0].SetActive(true);

    }

    public void exit()
    {
        maincamera.SetActive(true);
        CloseCCTV.Play("CCTVTransitionClose");
        cam[0].SetActive(false);
        cam[1].SetActive(false);
        Phone.onapp = false;
        CCTV_Manager.GetComponent<CCTV>().enabled = false;

    }
}
