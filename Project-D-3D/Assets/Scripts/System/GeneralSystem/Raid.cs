using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raid : MonoBehaviour
{

    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime;
    }
}
