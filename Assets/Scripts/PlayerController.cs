using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody2D myRigidBody;
    public float jumpSpeed;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool isGrounded; 







    // Use this for initialization
    void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();


	}
	


	// Update is called once per frame
	void Update () {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius , whatIsGround);



		if(Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidBody.velocity = new Vector3(moveSpeed, myRigidBody.velocity.y, 0f);

        }

        else if(Input.GetAxisRaw("Horizontal") < 0f)
        {
            myRigidBody.velocity = new Vector3(-moveSpeed, myRigidBody.velocity.y, 0f);
        }

        else
        {
            myRigidBody.velocity = new Vector3(0f, myRigidBody.velocity.y, 0f);
        }
        if (Input.GetButtonDown("Jump"))
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x,jumpSpeed,  0f);
        }
    }
}
