using UnityEngine;

public class PlayerScript : MonoBehaviour {

public Rigidbody rb;

public float forwardForce = 300f;
public float sidewaysForce = 50f;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 22, 500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);

        }
     if( Input.GetKey("m"))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0);

        }
    }
}
