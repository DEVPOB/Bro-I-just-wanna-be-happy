using UnityEngine;
public class Dead : MonoBehaviour
{
    [SerializeField] GameObject DeadScreen;
    public Stat stat;
    void Update()
    {
        if(stat.dead == true)
        {
            DeadScreen.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            /**
                *TODO: Dead Animation in next update;
            **/
            // StartCoroutine(DelayDead());
        }
    }
    // IEnumerator DelayDead()
    // {
    //     yield return new WaitForSeconds(3f);
    //     SceneManager.LoadScene("Main");
    // }
}
