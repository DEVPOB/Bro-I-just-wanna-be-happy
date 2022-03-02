using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallApp : MonoBehaviour
{
    [SerializeField]Phone_App Phone;
   
    void Update()
    {
        if(Phone.onapp == false)
        {
            gameObject.SetActive(false);
        }
    }
}
