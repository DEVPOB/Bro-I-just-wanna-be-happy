using UnityEngine;

public class Raid_Event : MonoBehaviour
{
    [SerializeField] GameObject RaidWall;
    [SerializeField] Rigidbody m_rigidbody;
    public Stat stat;
    public float m_thrust = 10f;


    void Update()
    {
        if(GameObject.Find("FBI_AI(Clone)") != null)
        {
            Invoke("raid",3f);
        }

    }
    void raid()
    {
        m_rigidbody.AddForce(transform.right * m_thrust,ForceMode.Impulse);
        stat.NeedWifiFix = true;
    }
}
