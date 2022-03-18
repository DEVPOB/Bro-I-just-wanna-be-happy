
using UnityEngine;

public class Running_AI : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SFXManager>().Play("BreakDoor");
    }
    void Update()
    {
        transform.position += Vector3.left * 20 *  Time.deltaTime;

    }
}
