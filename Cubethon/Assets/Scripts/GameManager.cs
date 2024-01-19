using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PlayerController movement;
    public Material PlayerAlive;
    public Material PlayerWin;
    public Material PlayerDead;

    public GameObject completeLevelUI;
    public GameObject completeGameUI;

    bool gameEnded = false;

    public float restartDelay = 2f;

    public void CompleteLevel()
    {
        if (!gameEnded) {
            gameEnded = true;
            movement.enabled = false;
            movement.GetComponent<MeshRenderer>().material = PlayerWin;
            completeLevelUI.SetActive(true);
            Invoke("RestartGame", restartDelay);
        }
    }
    
    public void EndGame()
    {
        if (!gameEnded) {
            gameEnded = true;
            movement.enabled = false;
            movement.GetComponent<MeshRenderer>().material = PlayerDead;
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
