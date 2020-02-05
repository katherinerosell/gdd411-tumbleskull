using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleWeedScript : MonoBehaviour {
    /**
     * Script adapted and expanded off the Iso-Cars Demo code
     * Using enums was much clearer for making the tumble weeds 
     * appear from different directions
     * */

    public float speed;
    float timer = 0.0f;
    Vector3 direction;
    public enum Direction { WestToEast, EastToWest, NorthToSouth, SouthToNorth }
    public Direction moveDirection;

    void Start () {
        Direction whichDir = (Direction)Random.Range(0,4);
        SetDirection(whichDir);
        speed = 5f;
    }

    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;
        if (8 <= timer && timer <= 35) {
            speed = 7;
        }
        if (36 <= timer && timer <= 60) {
            speed = 15;
        }
        if (61 <= timer && timer <= 80) {
            speed = 30;
        }
        if (81 <= timer && timer <= 100) {
            speed = 80;
        }

        GetComponent<Rigidbody>().velocity = direction * speed;
        //destroy if out of bounds
        if (GetComponent<Rigidbody>().position.x >= 60 || GetComponent<Rigidbody>().position.x <= -60) {
            Destroy(gameObject);
        }
        if (GetComponent<Rigidbody>().position.y >= 80 || GetComponent<Rigidbody>().position.y <= -65) {
            Destroy(gameObject);
        }
        //75, -35
        if (GetComponent<Rigidbody>().position.z >= 75 || GetComponent<Rigidbody>().position.z <= -35) {
            Destroy(gameObject);
        }



    }

    private void SetDirection(Direction newDir) {
        moveDirection = newDir;

        if (moveDirection == Direction.WestToEast) {
            Debug.Log("WEST to EAST ");
            transform.position = new Vector3(-40f, 1.07f, Random.Range(20f, -23f));
            direction = new Vector3(1, 0, 0);
        }
        if (moveDirection == Direction.EastToWest){
            Debug.Log("EAST to WEST ");
            transform.position = new Vector3(58f, 1.07f, Random.Range(20f, -23f));
            direction = new Vector3(-1, 0, 0);
        }
        if (moveDirection == Direction.NorthToSouth){
            Debug.Log("NORTH to SOUTH ");
            transform.position = new Vector3(Random.Range(-44f, 40f), 1.07f, 44f);
            direction = new Vector3(0, 0, -1);
        }
        if (moveDirection == Direction.SouthToNorth){
            Debug.Log("SOUTH to NORTH ");
            transform.position = new Vector3(Random.Range(-44f, 40f), 1.07f, -36f);
            direction = new Vector3(0, 0, 1);
        }

    }


    private void OnCollisionEnter(Collision collision)  {
        //if the ball hits a wall, ignore the collision and just go through
        if (collision.gameObject.tag == "InvisWall" || collision.gameObject.tag == "Cactus") {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
            Debug.Log("Invisible Wall hit, ignore it");
        }
        if (collision.gameObject.tag == "Player") {
            Debug.Log("Tumble Weed Hit Player!!");
        }


    }


}
