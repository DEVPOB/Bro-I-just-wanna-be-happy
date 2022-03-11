using UnityEngine;

public class Raid_Event : MonoBehaviour
{
    [SerializeField] GameObject RaidWall;
    [SerializeField] PlayerController Player;
    [SerializeField] float TimeRemainingToDie = 3f;
    [SerializeField] float TimeRemainingToSearch = 10f;

    public Stat stat;
    public float m_thrust = 10f;

    void Update()
    {
        if(GameObject.Find("FBI_AI(Clone)") != null)
        {
            RaidWall = GameObject.Find("RaidWall(Clone)");
            RaidWall.GetComponent<Rigidbody>().AddForce(transform.right * m_thrust,ForceMode.Impulse);
            Invoke("raid",2f);
            if(TimeRemainingToSearch <= 0)
            {
                Destroy(GameObject.Find("FBI_AI(Clone)"));
                TimeRemainingToSearch = 10f;
                Destroy(GameObject.Find("RaidWall(Clone)"));
                Instantiate(RaidWall);     
            }
        }
        else
        {
            TimeRemainingToDie = 3f;
        }

    }
    void raid()
    {
        Kill_FBI_AI();
        KillPlayer();
        stat.NeedWifiFix = true;
    }
    void KillPlayer()
    {
        if(Player.OnPhone == true)
        {
            TimeRemainingToDie = TimeRemainingToDie - Time.deltaTime;
        }
        if(TimeRemainingToDie <= 0)
        {
            stat.dead = true;
        }

    }
    void Kill_FBI_AI()
    {
        TimeRemainingToSearch = TimeRemainingToSearch - Time.deltaTime;

    }
    
}
