using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CallApp : MonoBehaviour
{
    [SerializeField] Phone_App Phone;
    [SerializeField] Animator Anim;
    [SerializeField] GameObject CallingUI;
    [SerializeField] TextMeshProUGUI CallingTo_Text;
    [SerializeField] TextMeshProUGUI TextCallingSuccess, TextCallingFail;
    private float CallingTime = 3f;
    private float Onphone;
    public bool CallingSuccess = false;
    public bool CallingToilet_Helper = false;

    void Update()
    {
        if (Phone.onapp == false)
        {
            gameObject.SetActive(false);
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
            }

        }

    }
   
    public void PlockerCalling()
    {
        CallingUI.SetActive(true);
        CallingTo_Text.text = "Plocker";
    }
    public void ToiletHelperCalling()
    {

        CallingToilet_Helper = true;
        CallingUI.SetActive(true);
        CallingTo_Text.text = "Toilet Helper";
        
    }
    public void CancelBtn()
    {
        CallingUI.SetActive(false);
        CallingTime = 3f;
        Anim.Play("CallingFail");

    }
}
