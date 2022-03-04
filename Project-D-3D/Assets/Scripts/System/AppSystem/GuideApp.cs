using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideApp : MonoBehaviour
{
    public Phone_App Phone;
    public GameObject GuideUI, Page1,Page2;
    void Update()
    {
        if(Phone.onapp == false)
        {
            GuideUI.SetActive(false);
        }
    }
    public void NextBtn()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
    }
    public void BackBtn()
    {
        Page1.SetActive(true);
        Page2.SetActive(false);
    }
}
