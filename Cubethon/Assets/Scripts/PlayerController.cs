using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;

    public float ForwardForce = 1000f;
    public float SideForce = 100f;
    public float JumpForce = 400f;

    //[HideInInspector]
    public bool onGround = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, ForwardForce*Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(SideForce*Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-SideForce*Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }
    }

    void Update()
    {
        if (onGround && Input.GetKeyDown("space")) {
            onGround = false;
            rb.AddForce(0, JumpForce, 0);
        }
    }
}
