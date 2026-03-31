using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutMenu : MonoBehaviour
{
    
    public void Start()
    {
        
    }

    public void SGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quitt()
    {
        Application.Quit();
    }
}
