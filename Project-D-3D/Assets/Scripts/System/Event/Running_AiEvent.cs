
using UnityEngine;

public class Running_AiEvent : MonoBehaviour
{
    public Stat stat;
    [SerializeField] Transform SpawnDoor;
    [SerializeField] float TimeRemainingToDie = 4f;
    public float m_thrust = 10f;
    [SerializeField] PlayerController Player;

    void Update()
    {
        if(GameObject.Find("Running_Ai(Clone)") != null)
        {
            KillRunner_Ai();
            DestroyDoor();
            KillPlayerByRunner();
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
        GameObject Door = GameObject.FindGameObjectWithTag("Door");
        if(Player.OnKick == true)
        {
            Destroy(Door);
            Instantiate(Door,SpawnDoor.position,Quaternion.identity);
            Destroy(GameObject.Find("Running_Ai(Clone)"));
            TimeRemainingToDie = 4f;
            Player.OnKick = false;
        }
        
    }
}
