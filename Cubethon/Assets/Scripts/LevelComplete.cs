using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    
    public GameManager gameManager;

    void OnLevelComplete()
    {
        gameManager.LoadNextLevel();
    }
}
