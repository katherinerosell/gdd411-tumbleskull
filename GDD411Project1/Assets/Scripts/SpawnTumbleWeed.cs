using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTumbleWeed : MonoBehaviour {

    //float timer = 0.0f;
    public GameObject tumbleWeed;
    //public Rigidbody twPrefab;
    //private int moveMode;
    //public KillTumbleWeed killTumbleWeedScript;

	void Start () {
        CreateTW();
        //tumbleWeed = tumbleWeed.GetComponent<Rigidbody>();
        //killTumbleWeedScript = tumbleWeed.GetComponent<KillTumbleWeed>();
        //twPrefab = Instantiate(tumbleWeed, new Vector3(-40f, 2.4f, Random.Range(20f, -23f)), transform.rotation);
        //StartCoroutine("LevelNum", null);
        //moveMode = LevelNum();
        //0 = west
        //1 = east 
        //2 = north
        //3 = south
	}

    void CreateTW() {
        Instantiate(tumbleWeed);
        Invoke("CreateTW", 1.3f);
    }
	
	
	void Update () {
        //timer += Time.deltaTime;
	}
    
    /*

    private int LevelNum() {

        int timerInt = (int) timer;

        if (0 <= timerInt && timerInt <= 2) {
            InvokeRepeating("SpawnWestWeeds", 0.1f, 4.5f);
            
           // SpawnEastWeeds();
            //instantiate from left
            //tumble weed prefab has slow speed
            return 0;
        }
        if (3 <= timerInt && timerInt <= 20) {
            //instantiate from right also
            //move these at same speed
            InvokeRepeating("SpawnEastWeeds", 0.1f, 3.5f);
            return 1;
        }
        //north
        if (21 <= timerInt && timerInt <= 25) {
            //instantiate from right also
            //move these at same speed
            
            return 2;
        }
        //south
        if (26 <= timerInt && timerInt <= 30) {
            //instantiate from right also
            //move these at same speed
            return 3;
        }
        else {
            return 0;
        }        
    }


    public void SpawnWestWeeds() {
        //x is -40, y is 2.4, z is random range 20 to -23
        Vector3 position = new Vector3(-40f, 2.4f,Random.Range(20f, -23f));
        //killTumbleWeedScript.moveMode = 0;
        Rigidbody prefab = Instantiate(tumbleWeed, position, transform.rotation);//Instantiate(tumbleWeed, position, transform.rotation);
        
        prefab.transform.Translate(10f, 0f, 0f);
        
        Debug.Log("Spawn WEST Weeds");
    }

    public void SpawnEastWeeds() {
        //killTumbleWeedScript.moveMode = 1;
        Vector3 position = new Vector3(58f, 2.4f, Random.Range(20f, -23f));

        Rigidbody prefab = Instantiate(tumbleWeed, position, transform.rotation);//Instantiate(tumbleWeed, position, transform.rotation);
        //prefab.transform.Translate(-10f, 0f, 0f);
        //prefab.transform.position = new Vector3(-10f, 0f, 0f);

    }

    **/

}
