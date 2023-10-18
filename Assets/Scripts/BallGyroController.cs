using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGyroController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 startPosition;
    private int coinCount;
    [Header ("Start Position Cords")]
    [SerializeField] private float xStart;
    [SerializeField] private float yStart;
    [SerializeField] private float zStart;
    [Header ("Ball Speed")]
    [SerializeField] private float Speed;
    [SerializeField] private InGameMenuDisplay canvasManager;
    
    


    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        startPosition = new Vector3(xStart, yStart, zStart);
        transform.position = startPosition;
        
        
    }

    
    void FixedUpdate()
    {
        float moveHorizontal = Input.acceleration.x;
        float moveVertical = Input.acceleration.y;

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rigidbody.AddForce(movement * Speed * Time.deltaTime); 
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trap")
        {
            rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            canvasManager.DisplayDeathScene();
        }

        if (other.tag == "Coin")
        {
            coinCount += 1;
            try
            {
                canvasManager.UpdateScore(coinCount);
            }
            catch { };
            
            Destroy(other.gameObject);
        }

        if (other.tag == "Finish")
        {
            canvasManager.DisplayFinishScene();
        }

    }
}
