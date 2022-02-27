using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    void Start()
    {
        MainCamera.SetActive(false);
        Cam1.SetActive(true);
    }

    void Update()
    {

    }
}
