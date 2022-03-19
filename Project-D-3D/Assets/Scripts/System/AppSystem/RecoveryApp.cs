
using UnityEngine;
using UnityEngine.UI;
public class RecoveryApp : MonoBehaviour
{
    [SerializeField] Image FixWifiBar;
    [SerializeField] Image FixLightBar;
    [SerializeField] Image FixWifiBtn;
    [SerializeField] Image FixLightBtn;
    [SerializeField]Phone_App Phone;
    [SerializeField] GameObject MainLight;
    public Stat StatNeeded;
    public float WiFi = 100f;
    public float Light = 100f;
    [SerializeField]private float max = 100f;
    [SerializeField]private float CurrentWifiFix,CurrentLightFix;
    [SerializeField]private bool OnWifiFix = false;
    [SerializeField]private bool OnLightFix = false;
    void Update()
    {
        if(Phone.onapp == false)
        {
            gameObject.SetActive(false);
        }
        if(StatNeeded.NeedWifiFix == true)
        {
            FixWifiBar.gameObject.SetActive(true);
            FixWifiBtn.gameObject.SetActive(true);
            if(OnWifiFix)
            {
                WiFi = WiFi - Time.deltaTime * 35;
                CurrentWifiFix = WiFi;
                FixWifiBar.fillAmount = CurrentWifiFix/max;
                if(WiFi <= 0)
                {
                    StatNeeded.NeedWifiFix = false;
                    FixWifiBar.gameObject.SetActive(false);
                    FixWifiBtn.gameObject.SetActive(false);
                    FixWifiBar.fillAmount = 1;
                    WiFi = 100f;
                    OnWifiFix = false;
                    FindObjectOfType<SFXManager>().Play("SelectSFX");
                }
            }
        }
        if(StatNeeded.NeedLightFix == true)
        {
            
            FixLightBar.gameObject.SetActive(true);
            FixLightBtn.gameObject.SetActive(true);
            
            if(OnLightFix)
            {
                Light = Light - Time.deltaTime * 35;
                CurrentLightFix = Light;
                FixLightBar.fillAmount = CurrentLightFix / max;
                if(Light <= 0)
                {
                    StatNeeded.NeedLightFix = false;
                    FixLightBar.gameObject.SetActive(false);
                    FixLightBtn.gameObject.SetActive(false);
                    FixLightBar.fillAmount = 1;
                    MainLight.SetActive(true);
                    Light = 100f;
                    OnLightFix = false;
                    FindObjectOfType<SFXManager>().Play("SelectSFX");
                }
            }
        }
        
    }
    public void WifiFix()
    {
        OnWifiFix = true;
    }
    public void LightFix()
    {
        OnLightFix = true;
    }
    
}
