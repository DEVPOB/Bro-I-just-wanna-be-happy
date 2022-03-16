
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip test;
    public static SFXManager sfxInstance;

    void Awake()
    {
        if(sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
