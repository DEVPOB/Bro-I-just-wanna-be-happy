using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAIManager : MonoBehaviour
{
    public GameObject NormalFriend_Ai;
    public GameObject RunningFriend_Ai;
    public GameObject MuscleGuy_Ai;
    public GameObject FBI_Ai;
    [Range(0f,100f)]private float SpawnRate = 100f;
    public GameObject[] All_Ai;
    public GameObject[] Spawn_Ai;
    void Start()
    {

    }

    void Update()
    {
        GameObject[] All_Ai = GameObject.FindGameObjectsWithTag("Enemy");
        if(All_Ai.Length >= 2)
        {
            // Don't Spawn;
        }
        /**
            *TODO SPAWN RATE
        **/

    }
    void Spawn()
    {
    
    }
}
