using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    // This is a reference to the RigidBody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;

    // We marked this as "Fixed"Updated because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force of 2000 on the z-axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
