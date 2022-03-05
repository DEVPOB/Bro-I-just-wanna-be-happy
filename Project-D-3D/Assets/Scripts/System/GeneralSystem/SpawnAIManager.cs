using UnityEngine;

public class SpawnAIManager : MonoBehaviour
{
    public GameObject NormalFriend_Ai;
    public GameObject RunningFriend_Ai;
    public GameObject MuscleGuy_Ai;
    public GameObject GuyInfrontDoor_Ai;
    public GameObject FBI_Ai;
    public Transform SpawnPoint1;
    public float random;
    void Awake()
    {
        test();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void test()
    {
        for(int i = 0; i < 10; i++)
        {
            Spawn();
        }
    }
    void Spawn()
    {
        float random = Random.Range(0,100);
        if(random > 0 && random <= 30)
        {
            Instantiate(NormalFriend_Ai,SpawnPoint1.position,Quaternion.identity);
        }
        else if(random > 31 && random <= 41)
        {
            Instantiate(RunningFriend_Ai,SpawnPoint1.position,Quaternion.identity);
        }
        else if(random > 42 && random <= 60)
        {
            Instantiate(MuscleGuy_Ai,SpawnPoint1.position,Quaternion.identity);
        }
        else if(random > 61 && random <= 66)
        {
            Instantiate(FBI_Ai,SpawnPoint1.position,Quaternion.identity);
        }
        else if(random > 67 && random <= 100)
        {
            Instantiate(GuyInfrontDoor_Ai,SpawnPoint1.position,Quaternion.identity);
        }
    }

  
}
