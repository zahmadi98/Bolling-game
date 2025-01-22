using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float throwForce = 10f; 
    private bool isReadyToThrow = false; 

    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(horizontalInput, 0, 0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isReadyToThrow = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isReadyToThrow)
        {
            ThrowBall();
        }
    }

    void ThrowBall()
    {
        
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
            isReadyToThrow = false; 
        }
    }
}
