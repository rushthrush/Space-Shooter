using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public float tilt;
    public float bWidth, bHeight;
    public GameObject projectile;
    public float reloadTime;
    public bool shootReady = true;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
     void Update() {

        if (Input.GetButton("Fire1") && shootReady)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            shootReady = false;
            Invoke("ReloadWeapon", reloadTime);
        }
    }
    void ReloadWeapon()
    {
        shootReady = true;
    }
    // Update is called once per frame
    void FixedUpdate () {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hInput,vInput,0);

        rb.velocity = movement * speed;

        rb.position = new Vector3(
            Mathf. Clamp(rb.position.x, -bWidth / 2, bWidth / 2),
            Mathf. Clamp(rb.position.y, -bHeight / 2, bHeight / 2),
            0);
        rb.rotation = Quaternion.Euler(
            vInput * tilt,
            0,
            hInput * -tilt);
    }
}
