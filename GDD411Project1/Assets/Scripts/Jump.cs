using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float jumpForce = 100;
    private Rigidbody playerRB;
    public LayerMask groundLayer; //be aware of where the ground is
    public SphereCollider col; //using the player's sphere collider
	// Use this for initialization
	void Start () {

        playerRB = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();

	}
	
	// Update is called once per frame
	void Update () {

        if (IsGrounded() && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); //impulse is a stronger force than force

        }


	}

    private bool IsGrounded() {
        //check within bounds of where the capsule starts
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, 
            col.bounds.min.y, col.bounds.min.z), col.radius * 0.9f, groundLayer); 
        //we can only jump when we are just above this mini check radius        
    }


}
