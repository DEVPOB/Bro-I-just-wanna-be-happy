
using UnityEngine;

public class Friend_AI : MonoBehaviour
{
    public Stat stat;
    [SerializeField] CCTV CCTVScript;
    public CallApp HasCall;

    [SerializeField] float TimeRemainingToDie = 15f;
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
                CCTVScript.exit();
                stat.dead = true;

            }
        }
        else if(TimeRemainingToDie > 0)
        {
            if(HasCall.CallingSuccess == true && HasCall.CallingToilet_Helper == true)
            {
                Destroy(GameObject.Find("NormalFriend_AI(Clone)"));
                TimeRemainingToDie = 15f;
                HasCall.CallingSuccess = false;
                HasCall.CallingToilet_Helper = false;
            }
        }
    }
}
