using UnityEngine;

public class FBI_AI : MonoBehaviour
{
    [SerializeField] GameObject RaidWall;
    [SerializeField] Rigidbody m_rigidbody;
    public Stat stat;
    public float m_thrust = 50f;

    
    void Start()
    {
        
    }

    void Update()
    {
        if(GameObject.Find("FBI_AI(Clone)") != null)
        {
            Invoke("raid",5f);

        }

    }
    void raid()
    {
        m_rigidbody.AddForce(transform.right * m_thrust,ForceMode.Impulse);
        stat.NeedWifiFix = true;
    }
}
