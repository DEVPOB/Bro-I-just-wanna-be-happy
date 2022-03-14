using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]GameObject UpdateMenu;
    public void PlayBtn()
    {
        SceneManager.LoadScene("Main");
    }
    public void UpdateBtn()
    {
        UpdateMenu.SetActive(true);
    }
    public void BackBtn()
    {
        UpdateMenu.SetActive(false);
    }
    public void ExitBtn()
    {
        Application.Quit();
    }
    public void Tolink(string URL)
    {
        Application.OpenURL(URL);
    }

}
