
using UnityEngine;
using UnityEngine.UI;

public class StatApp : MonoBehaviour
{
    [SerializeField] Image SanityBar;
    [SerializeField] Stat Stat;
    [SerializeField] Phone_App Phone;
    private float MaxSanity = 100f;
    private float CurrentSanity;
    void Update()
    {
        if(Phone.onapp == false)
        {
            gameObject.SetActive(false);
        }
        Sanity();
    }
    void Sanity()
    {
        CurrentSanity = Stat.sanity;
        SanityBar.fillAmount = CurrentSanity / MaxSanity;
    
    }
}
