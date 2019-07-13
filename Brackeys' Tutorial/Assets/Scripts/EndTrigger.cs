using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public PlayerCollision playerCollision;

    void OnTriggerEnter(Collider other)
    {

        if(playerCollision.movement.enabled == true)
        {
            gameManager.CompleteLevel();
        }

    }
}
