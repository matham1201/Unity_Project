using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void NouvellePartie()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
