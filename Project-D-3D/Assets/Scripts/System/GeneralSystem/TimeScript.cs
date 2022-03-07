using System;

using UnityEngine;
using TMPro;
public class TimeScript : MonoBehaviour
{
    private float CurrnetTime = 0;
    [SerializeField] Stat stat;
    public TextMeshProUGUI[] TimeText;
    void Awake()
    {
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(stat.dead == false)
        {
            double CurrnetTimeRound;
            CurrnetTime += Time.deltaTime;
            CurrnetTimeRound = Math.Round(CurrnetTime);
            TimeText[0].GetComponent<TextMeshProUGUI>().text = CurrnetTimeRound.ToString();
            TimeText[1].GetComponent<TextMeshProUGUI>().text = CurrnetTimeRound.ToString();
        }

    }
}
