
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Phone;
    [SerializeField] GameObject CameraMain;
    [SerializeField] GameObject PauseMenu;
    private float rotationOnX;
    private float rotationOnY;
    private float mouseSensitivity = 90f;
    public bool OnPhone = false;
    public GameObject quotes;
    public Quotes QuotesScript;
    public bool OnKick = false;

    private float lastput;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        if (OnPhone != true)
        {
            HoldDoor();
            FpsCamera();

        }
        if (Phone.GetComponent<Phone_App>().onapp == false)
        {
            OpenPhone();
        }
        PauseGame();

    }
    void FpsCamera()
    {
        float mousey = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        float mousex = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;

        rotationOnX -= mousey;
        rotationOnY += mousex;
        rotationOnX = Mathf.Clamp(rotationOnX, -90f, 90f);
        rotationOnY = Mathf.Clamp(rotationOnY, -90f, 90f);
        transform.localEulerAngles = new Vector3(rotationOnX, rotationOnY, 0f);
    }
    void OpenPhone()
    {
        if (Input.GetKeyDown(KeyCode.E) && OnPhone == false)
        {
            if (Time.time - lastput < .5f)
            {
                return;
            }
            FindObjectOfType<SFXManager>().Play("PickPhone");
            Phone.GetComponent<Animator>().Play("PutPhone");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            lastput = Time.time;
            OnPhone = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && OnPhone == true)
        {
            if (Time.time - lastput < .5f)
            {
                return;
            }
            lastput = Time.time;
            FindObjectOfType<SFXManager>().Play("ClosePhone");
            Phone.GetComponent<Animator>().Play("ClosePhone");
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            OnPhone = false;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            quotes.SetActive(true);
        }

        if (quotes.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Keypad1))
        {
            quotes.SetActive(false);
            QuotesScript.Start();
            QuotesScript.fullText = "I'M IN";

        }
    }
    void HoldDoor()
    {
        if (Input.GetKeyDown(KeyCode.F) && OnPhone == false)
        {
            FindObjectOfType<SFXManager>().Play("LockDoorSFX");
            OnKick = true;
            if (GameObject.Find("Running_Ai(Clone)") == null)
            {
                OnKick = false;
            }
        }
    }
    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }


}
