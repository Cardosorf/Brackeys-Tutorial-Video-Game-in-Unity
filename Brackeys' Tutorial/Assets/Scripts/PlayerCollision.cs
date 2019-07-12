using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMoviment movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obsticle")
        {
            movement.enabled = false;
        }
        
    }
}