using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject spawnObject;
    public float spawnWait;
    public float spawnRate;
    public Vector3 spawnPosition;

	// Use this for initialization
	void Start () {
       InvokeRepeating("Spawn", spawnWait, spawnRate);
	}
	
	// Update is called once per frame
	void Spawn () {
            Instantiate(spawnObject, spawnPosition, Quaternion.identity);
	}
}
