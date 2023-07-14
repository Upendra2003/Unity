using UnityEngine;

public class Collosions : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
