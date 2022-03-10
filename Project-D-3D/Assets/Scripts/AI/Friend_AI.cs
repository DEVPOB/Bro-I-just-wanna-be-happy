
using UnityEngine;

public class Friend_AI : MonoBehaviour
{
    public GameObject Friend_Ai;
    public Stat stat;
    public CallApp HasCall;
    private float TimeRemainingToDie = 15f;
    void Update()
    {
        if(GameObject.Find("NormalFriend_AI(Clone)") != null)
        {
            KillPlayerByFriend();
        }
    }
    void KillPlayerByFriend()
    {
        TimeRemainingToDie = TimeRemainingToDie - Time.deltaTime;
        if(TimeRemainingToDie <= 0)
        {
            if(HasCall.CallingSuccess == false || HasCall.CallingToilet_Helper == false)
            {
                Destroy(GameObject.Find("NormalFriend_AI(Clone)"));
                stat.dead = true;

            }
        }
        else if(TimeRemainingToDie > 0)
        {
            if(HasCall.CallingSuccess == true && HasCall.CallingToilet_Helper == true)
            {
                Destroy(GameObject.Find("NormalFriend_AI(Clone)"));
                TimeRemainingToDie = 15f;
            }
        }
    }
}
