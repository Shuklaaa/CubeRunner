using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float sidewayForce = 500f;
    //This is a refrence to the Rigidbody component called "rb". 
    public Rigidbody rb;
    // We marked this as "Fixed"Update because we 
    // are using it to mess with physics 
    void FixedUpdate()
    { 
       

		if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		 if(rb.position.y < -1f)
        {
            Time.timeScale = 0f;
        }
        

    }
	
	
}
