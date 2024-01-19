using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    public GameManager gameManager;

    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Player") {
            gameManager.CompleteLevel();
        }
    }
}
