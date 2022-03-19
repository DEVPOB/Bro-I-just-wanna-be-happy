
using UnityEngine;

public class MuscleGuy_AI_Event : MonoBehaviour
{
    public CCTV CCTVScirpt;
    [SerializeField] float TimeLookAtMuscleGuy = 5f;
    [SerializeField] float TimeRemainingToDie = 10f;
    public Stat stat;
    void Update()
    {
        if(GameObject.Find("MuscleGuy_AI(Clone)") != null)
        {
            KillPlayerByMuscleGuy();
            KillMuscleGuy();
        }
    }
    void KillPlayerByMuscleGuy()
    {
        if(CCTVScirpt.openlight == false)
        {
            TimeRemainingToDie = TimeRemainingToDie - Time.deltaTime;
            if(TimeRemainingToDie <= 0)
            {
                CCTVScirpt.exit();
                stat.dead = true;

            }
        }
    }
    void KillMuscleGuy()
    {
        if(CCTVScirpt.openlight == true)
        {
            TimeLookAtMuscleGuy = TimeLookAtMuscleGuy - Time.deltaTime;
            if(TimeLookAtMuscleGuy <= 0)
            {
                TimeRemainingToDie = 20f;
                TimeLookAtMuscleGuy = 5f;
                Destroy(GameObject.Find("MuscleGuy_AI(Clone)"));
            }
        }
    }
}
