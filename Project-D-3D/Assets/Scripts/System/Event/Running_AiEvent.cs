
using UnityEngine;

public class Running_AiEvent : MonoBehaviour
{
    public Stat stat;
    [SerializeField] float TimeRemainingToDie = 4f;
    public float m_thrust = 10f;
    [SerializeField] PlayerController Player;
    private float TimeRemainingToDestroy = 3f;
    
    void Update()
    {
        if(GameObject.Find("Running_Ai(Clone)") != null)
        {
            TimeRemainingToDestroy = TimeRemainingToDestroy - Time.deltaTime;
            if(TimeRemainingToDestroy <= 0)
            {
                Destroy(GameObject.Find("Running_Ai(Clone)"));
            }
            DestroyDoor();
            KillPlayerByRunner();
            KillRunner_Ai();
        }

        
    }
    void DestroyDoor()
    {
        GameObject Door = GameObject.FindGameObjectWithTag("Door");
        Door.GetComponent<Rigidbody>().AddForce(-transform.right * m_thrust,ForceMode.Impulse);

    }
    void KillPlayerByRunner()
    {
        TimeRemainingToDie = TimeRemainingToDie - Time.deltaTime;
        if(TimeRemainingToDie <= 0)
        {
            stat.dead = true;
        }
    }
    void KillRunner_Ai()
    {
        if(Player.OnKick == true)
        {
            Destroy(GameObject.Find("KillRunner_Ai(Clone)"));
        }
        
    }
}
