using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerController movement;

    void FixedUpdate() {
        if (transform.position.y < 0f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (collisionInfo.collider.tag == "Ground") {
            movement.onGround = true;
        }
    }
}
