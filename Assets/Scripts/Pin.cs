using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isFallen = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            
            if (!isFallen)
            {
                
                if (transform.position.y < 0.8) 
                {
                    isFallen = true; 
                    FindObjectOfType<ScoreManager>().AddScore(1); 
                    Debug.Log("Pin has fallen! Score added.");
                }
            }
        }
    }

    void Update()
    {
        
        if (!isFallen && transform.position.y < 0.8) 
        {
            isFallen = true; 
            FindObjectOfType<ScoreManager>().AddScore(1); 
            Debug.Log("Pin has fallen! Score added.");
        }
    }
}

