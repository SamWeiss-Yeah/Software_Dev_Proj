using System.Threading;
using UnityEngine;


public class Player_Moves : MonoBehaviour
{

    public Rigidbody rb; // the physics of an object
    public float dir_force = 500;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, dir_force * Time.deltaTime);  // Forwards
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -dir_force * Time.deltaTime);  // Backwards
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-dir_force * Time.deltaTime, 0, 0);  // Left
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(dir_force * Time.deltaTime, 0, 0);  // Right
        }
        if (Input.GetKey("p"))
        {
            rb.AddForce(0, dir_force * Time.deltaTime, 0);   // Jump
        }
    }
}
