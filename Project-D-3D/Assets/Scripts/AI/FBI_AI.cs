
using UnityEngine;

public class FBI_AI : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.right * 2 *  Time.deltaTime;
    }
}
