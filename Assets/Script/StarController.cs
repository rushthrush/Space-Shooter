using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    //public float tiltMax;
    public float killY;
    public float xRange;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //transform.Rotate(0, 0, Random.Range(-tiltMax, tiltMax));
        Vector3 p = transform.position;
        p.x += Random.Range(-xRange, xRange);
        transform.position = p;


    }


   /* void FixedUpdate()
    {
        var target = GameObject.FindGameObjectWithTag("GameTag");
        GameData GD = target.GetComponent<GameData>();
        GD.UpdateSpeed();
        transform.Translate(-transform.up * Time.deltaTime * GD.speed);
        if (transform.position.y < killY)
        {
            Destroy(gameObject);
        }

    }*/
}
