using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] spawnee;
    public int spawnTime = 1;
    private int randomInt;
    float position;
    // Use this for initialization
    void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        randomInt = Random.Range(0, spawnee.Length);
        position = Random.Range(8f, -8f);
        this.transform.position = new Vector3(position, transform.position.y, transform.position.z);
        Instantiate(spawnee[randomInt], transform.position, transform.rotation);
    }


}
