using System.Collections;
using UnityEngine;
using TMPro;


public class Quotes : MonoBehaviour
{
    public float delay = 0.01f;
    public string fullText;
    private string currentText = "";

    void Start()
    {
        StartCoroutine(ShowText());   
    }
    IEnumerator ShowText()
    {     
        while(true)
        {
            for(int i = 0; i < fullText.Length + 1 ; i++)
            {
                currentText = fullText.Substring(0,i);
                this.GetComponent<TextMeshProUGUI>().text = currentText;
                yield return new WaitForSeconds(delay);
                this.GetComponent<TextMeshProUGUI>().text = "";
                        
            }

        }
    }
}
