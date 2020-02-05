using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTumbleWeed : MonoBehaviour {

    private Rigidbody tumbleWeedRB;
    private Collider twCollider;

    public Collider invisWall1;
    public Collider invisWall2;
    public Collider invisWall3;
    public Collider invisWall4;

    public int moveMode;
    // Use this for initialization
    void Start () {
        tumbleWeedRB = GetComponent<Rigidbody>();
        twCollider = GetComponent<Collider>();
        moveMode = 0;
        /**
        invisWall1 = GetComponent<Collider>();
        invisWall2 = GetComponent<Collider>();
        invisWall3 = GetComponent<Collider>();
        invisWall4 = GetComponent<Collider>();


        Physics.IgnoreCollision(invisWall1, twCollider);
        Physics.IgnoreCollision(invisWall2, twCollider);
        Physics.IgnoreCollision(invisWall3, twCollider);
        Physics.IgnoreCollision(invisWall4, twCollider);
    **/
    }
	
	// Update is called once per frame
	void Update () {

        if (tumbleWeedRB.position.x >= 60 || tumbleWeedRB.position.x <= -60) {
            Destroy(tumbleWeedRB.gameObject);
        }
        if (tumbleWeedRB.position.y >= 80 || tumbleWeedRB.position.y <= -65) {
            Destroy(tumbleWeedRB.gameObject);
        }
        //75, -35
        if (tumbleWeedRB.position.z >= 75 || tumbleWeedRB.position.z <= -35) {
            Destroy(tumbleWeedRB.gameObject);
        }

        //tumbleWeedRB.transform.Translate()

        //transform.Translate(Vector3.right);
        /**
        switch (moveMode) {
            case 0:
                transform.Translate(5f, 0f, 0f);
                break;
            case 1:
                transform.Translate(-5f, 0f, 0f);
                break;
            case 2:
                transform.Translate(-5f, 0f, 0f);
                break;
            case 3:
                transform.Translate(-5f, 0f, 0f);
                break;
        }
        **/

    }

    private void OnCollisionEnter(Collision collision)  {
        //if the ball hits a wall, ignore the collision and just go through
        if (collision.gameObject.tag == "InvisWall") {
            Physics.IgnoreCollision(collision.collider, twCollider);
            Debug.Log("Invisible Wall hit, ignore it");
        }
        if (collision.gameObject.tag == "Player") {
            Debug.Log("Tumble Weed Hit Player!!");
        }


    }


}
