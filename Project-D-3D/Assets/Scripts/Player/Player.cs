using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float rotationOnX;
    private float rotationOnY;
    private float mouseSensitivity = 90f;
    public Transform player;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        FpsCamera();
    }
    void FpsCamera()
    {
        float mousey = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        float mousex = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;

        rotationOnX -= mousey;
        rotationOnY += mousex;
        rotationOnX = Mathf.Clamp(rotationOnX, -90f, 90f);
        rotationOnY = Mathf.Clamp(rotationOnY, -90f, 90f);
        transform.localEulerAngles = new Vector3(rotationOnX, rotationOnY ,0f);
    }
}
