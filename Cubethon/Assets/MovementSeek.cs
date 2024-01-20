using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSeek : MonoBehaviour
{
    public Transform Target;

    public float MaxSpeed = 10f;
    public float Range = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Target.position) <= Range) {
            Vector2 velocity = new Vector2(Target.position.x - transform.position.x, Target.position.z - transform.position.z);
            velocity.Normalize();
            velocity *= MaxSpeed;

            transform.GetComponent<Rigidbody>().velocity = new Vector3(velocity.x, transform.GetComponent<Rigidbody>().velocity.y, velocity.y);

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180-Mathf.Atan2(-velocity.x, velocity.y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }
}
