
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Phone;
    private float rotationOnX;
    private float rotationOnY;
    private float mouseSensitivity = 90f;
    public Transform player;
    private bool OnPhone = false;
    public GameObject quotes;
    public Quotes QuotesScript;

    private float lastput;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        if(OnPhone != true)
        {
            FpsCamera();

        }
        if(Phone.GetComponent<Phone_App>().onapp == false)
        {
            OpenPhone();
        }
        
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
    void OpenPhone()
    {
        if(Input.GetKeyDown(KeyCode.E) && OnPhone == false)
        {
            if (Time.time - lastput < .5f)
            {
                return;
            }
            Phone.GetComponent<Animator>().Play("PutPhone");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            lastput = Time.time;
            OnPhone = true;
        }
        if(Input.GetKeyDown(KeyCode.E) && OnPhone == true)
        {
            if (Time.time - lastput < .5f)
            {
                return;
            }
            lastput = Time.time;
            Phone.GetComponent<Animator>().Play("ClosePhone");
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            OnPhone = false;
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            quotes.SetActive(true);
        }
        
        if(quotes.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Keypad1))
        {
            quotes.SetActive(false);
            QuotesScript.enabled = true;
            QuotesScript.fullText = "I'M IN";
           
        }
    }
   
   
}
