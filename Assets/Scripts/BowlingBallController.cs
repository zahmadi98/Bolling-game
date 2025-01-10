using UnityEngine;

public class BowlingBallController : MonoBehaviour
{
    public float throwForce = 30f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
        }
    }

    void ThrowBall()
    {
        rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
    }
}

