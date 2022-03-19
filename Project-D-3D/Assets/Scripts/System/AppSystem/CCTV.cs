
using UnityEngine;

public class CCTV : MonoBehaviour
{
    public GameObject CCTV_Manager;
    [SerializeField] GameObject Active_SpotLightCam1,Active_SpotLightCam2;

    public GameObject maincamera;
    [SerializeField]Phone_App Phone;
    [SerializeField] Stat stat;
    [SerializeField] GameObject CamError;
    public GameObject[] cam;
    private float lastput;
    public Animator CloseCCTV;
    public bool openlight = false;
    [SerializeField] bool HeldKey = false;
  
    void Update()
    {
        if(stat.NeedWifiFix == true && maincamera.activeInHierarchy != true)
        {
            cam[0].SetActive(true);
            cam[1].SetActive(false);
            CamError.SetActive(true);
        }
        
        if(HeldKey == false)
        {
            Active_SpotLightCam1.SetActive(false);
            Active_SpotLightCam2.SetActive(false);
            openlight = false;
        }
       
        if(cam[0].activeInHierarchy == true)
        {
            if(Input.GetMouseButton(1))
            {
                FindObjectOfType<SFXManager>().Play("OpenLightSFX");
                Active_SpotLightCam1.SetActive(true);
            }

        }
        else if(cam[1].activeInHierarchy == true)
        {
            if(Input.GetMouseButton(1))
            {
                FindObjectOfType<SFXManager>().Play("OpenLightSFX");
                Active_SpotLightCam2.SetActive(true);
                openlight = true;
            
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
        FindObjectOfType<SFXManager>().Play("ExitSFX");
        maincamera.SetActive(true);
        CloseCCTV.Play("CCTVTransitionClose");
        CamError.SetActive(false);
        cam[0].SetActive(false);
        cam[1].SetActive(false);
        Phone.onapp = false;
        

    }
}
