using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutMenu : MonoBehaviour
{
    
    public void Start()
    {
        SceneManager.LoadScene("1");
    }

    public void Quitt()
    {
        Application.Quit();
    }
}
