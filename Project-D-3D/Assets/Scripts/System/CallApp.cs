using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CallApp : MonoBehaviour
{
    [SerializeField]Phone_App Phone;
    [SerializeField]GameObject CallingUI;
    [SerializeField]TextMeshProUGUI CallingTo_Text;
    private float CallingTime = 3f;
    private float Onphone;

   
    void Update()
    {
        if(Phone.onapp == false)
        {
            gameObject.SetActive(false);
        }
        if(CallingUI.activeInHierarchy == true)
        {
            CallingTime = CallingTime - Time.deltaTime;
            if(CallingTime <= 0)
            {
                CancelBtn();
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
        CallingUI.SetActive(true);
        CallingTo_Text.text = "Toilet Helper";

    }
    public void CancelBtn()
    {
        CallingUI.SetActive(false);
        CallingTime = 3f;
    }
}
