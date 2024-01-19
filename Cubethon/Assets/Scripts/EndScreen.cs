using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    
    public void Quit()
    {
        Debug.Log("QUIT");
        //Application.Quit();
        SceneManager.LoadScene(0);
    }
}
