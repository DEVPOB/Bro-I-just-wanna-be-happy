using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dead : MonoBehaviour
{
    public Stat stat;
    void Update()
    {
        if(stat.dead == true)
        {
            StartCoroutine(DelayDead());
        }
    }
    IEnumerator DelayDead()
    {
        print("Now Dead");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main");
    }
}
