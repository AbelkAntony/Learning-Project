using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Serializefield - make it visible in the inspector
    //[SerializeField] private float speed;

    [SerializeField] private Vector3 moveDirection;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
		// transform.position += (moveDirection * Time.deltaTime) * Input.GetAxis("Vertical"); 
		if (Input.GetKeyDown(KeyCode.Space))
		{
           // moveDirection.x = rb.velocity.x;
           // moveDirection.y = rb.velocity.y;
           // rb.velocity = moveDirection;
           rb.AddForce(moveDirection);
		}
    }
}
