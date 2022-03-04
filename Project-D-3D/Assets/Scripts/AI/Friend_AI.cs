using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend_AI : MonoBehaviour
{
    public CallApp HasCall;
    public float TimeRemainingToDie = 15f;
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
                print("DEAD");
            }
        }
    }
}
