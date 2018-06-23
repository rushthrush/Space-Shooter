using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    public float lifetime;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.up * speed;
        Invoke("Remove", lifetime);
	}
	
	// Update is called once per frame
	void Remove () {
        Destroy(gameObject);
	}
}
