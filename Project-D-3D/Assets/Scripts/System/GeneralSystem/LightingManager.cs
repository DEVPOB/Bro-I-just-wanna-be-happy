using System.Collections;
using UnityEngine;

public class LightingManager : MonoBehaviour
{
    public GameObject MainSpotLight,SpotLightAtCam1,SpotLightAtCam2;
    private float random;
    private float lastrandom;
    private IEnumerator coroutine;
    void Start()
    {
        StartCoroutine(Light());
    }
    IEnumerator Light()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            SpotLightAtCam1.SetActive(false);
            SpotLightAtCam2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            SpotLightAtCam1.SetActive(true);
            SpotLightAtCam2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            SpotLightAtCam1.SetActive(false);
            SpotLightAtCam2.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            SpotLightAtCam1.SetActive(true);
        }
    }
  
}
