using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMain : MonoBehaviour
{
    public Vector3 camerasetoff;
    public float damp;
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    void FixedUpdate()
    {
        Vector3 moveposition = target.position + camerasetoff;
        transform.position = Vector3.SmoothDamp(transform.position,moveposition,ref velocity,damp);
    }
}
