
using UnityEngine;

public class Running_AI : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SFXManager>().Play("BreakDoor");
        FindObjectOfType<SFXManager>().Play("Running_AiSound2");
    }
    void Update()
    {
        transform.position += Vector3.left * 20 *  Time.deltaTime;

    }
}
