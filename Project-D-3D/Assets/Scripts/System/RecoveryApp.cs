using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryApp : MonoBehaviour
{
    public Phone_App Phone;
    void Update()
    {
        if(Phone.onapp == false)
        {
            gameObject.SetActive(false);
        }
    }
    
}
