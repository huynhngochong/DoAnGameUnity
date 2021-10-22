using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{

    Rigidbody rb;

    [SerializeField] float movementSpeed = 6f;

    [SerializeField] float JumpForce = 6f;

    [SerializeField] Transform groundCheck;

    [SerializeField] LayerMask Ground;

    [SerializeField] AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            Jump();
        }
       
    }
    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.y);
        jumpSound.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Head"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }

    }

    bool isGrounded()
    {
       return Physics.CheckSphere(groundCheck.position, .1f, Ground);
    }
}
