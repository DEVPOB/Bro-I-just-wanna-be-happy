using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend_AI : MonoBehaviour
{
    public GameObject Friend_Ai;
    public Stat stat;
    public CallApp HasCall;
    private float TimeRemainingToDie = 15f;
    void Update()
    {
    }
    void KillPlayerByFriend()
    {
        TimeRemainingToDie = TimeRemainingToDie - Time.deltaTime;
        if(TimeRemainingToDie <= 0)
        {
            if(HasCall.CallingSuccess == false || HasCall.CallingToilet_Helper == false)
            {
                Destroy(gameObject);
                stat.dead = true;
            }
        }
    }
}
