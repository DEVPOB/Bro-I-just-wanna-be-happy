using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    public GameObject CCTV_Manager;

    public GameObject maincamera;
    public GameObject[] cam;
    private float lastput;
    public Animator CloseCCTV;


    
    void Start()
    {
        maincamera.SetActive(false);
        cam[1].SetActive(true);
    }

    void Update()
    {

    }
    public void SwitchToCam2()
    {
        cam[0].SetActive(false);
        cam[1].SetActive(true);
    }
    public void SwitchToCam1()
    {
        cam[1].SetActive(false);
        cam[0].SetActive(true);

    }

    public void exit()
    {
        maincamera.SetActive(true);
        CloseCCTV.Play("CCTVTransitionClose");
        cam[0].SetActive(false);
        cam[1].SetActive(false);
        CCTV_Manager.GetComponent<CCTV>().enabled = false;

    }
}
