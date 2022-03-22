
using UnityEngine;

public class FBI_AI : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SFXManager>().Play("Raid_Event");
        FindObjectOfType<SFXManager>().Play("ECM_JAMMER");
        
    }
    void Update()
    {
        transform.position += Vector3.right * 2 *  Time.deltaTime;
    }
}
