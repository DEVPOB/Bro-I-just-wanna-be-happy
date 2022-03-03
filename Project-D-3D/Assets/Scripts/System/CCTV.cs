using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    public GameObject CCTV_Manager;
    [SerializeField] GameObject Active_SpotLightCam1,Active_SpotLightCam2;

    public GameObject maincamera;
    [SerializeField]Phone_App Phone;
    public GameObject[] cam;
    private float lastput;
    public Animator CloseCCTV;
    [SerializeField] bool HeldKey = false;
    void Update()
    {
        if(HeldKey == false)
        {
            Active_SpotLightCam1.SetActive(false);
            Active_SpotLightCam2.SetActive(false);
        }
        if(!Input.GetKey(KeyCode.Q))
        {
            HeldKey = false;    
        }
        if(cam[0].activeInHierarchy == true)
        {
            if(Input.GetMouseButton(1))
            {
                Active_SpotLightCam1.SetActive(true);
                HeldKey = true;
            }

        }
        else if(cam[1].activeInHierarchy == true)
        {
            if(Input.GetMouseButton(1))
            {
                Active_SpotLightCam2.SetActive(true);
            }
        }
    }

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
