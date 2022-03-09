
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
    private float max = 100f;
    private float CurrentWifiFix,CurrentLightFix;
    private bool OnWifiFix = false;
    private bool OnLightFix = false;
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
                    FixWifiBar.enabled = false;
                    FixWifiBtn.enabled = false;
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
                    FixLightBar.enabled = false;
                    FixLightBtn.enabled = false;
                    MainLight.SetActive(true);
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
