
using UnityEngine;

public class Running_AI : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * 20 *  Time.deltaTime;

    }
}
