using UnityEngine;

public class AmbientToilet : MonoBehaviour
{
    private static AmbientToilet BackgroundMusic;
    void Awake()
    {
        if(BackgroundMusic != null && BackgroundMusic != this)
        {
            Destroy(this.gameObject);
            return;
        }
        BackgroundMusic = this;
        DontDestroyOnLoad(this);
    }
}
