using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    //public float tiltMax;
    public float killY;
    public float xRange;
    public GameObject explosion;
    public float explodeLifeTime;

    void Start () {
        rb = GetComponent<Rigidbody>();
        //transform.Rotate(0, 0, Random.Range(-tiltMax, tiltMax));
        Vector3 p = transform.position;
        p.x += Random.Range(-xRange, xRange);
        transform.position = p;

       
    }
	
	
 void FixedUpdate () {
        var target = GameObject.FindGameObjectWithTag("GameTag");
        GameData GD = target.GetComponent<GameData>();
        GD.UpdateSpeed();
        transform.Translate(-transform.up * Time.deltaTime * (GD.speed));
        if (transform.position.y < killY)
        {
            Destroy(gameObject);
        }

    }
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            //increase the player score.
            //player.score++;
            var target = GameObject.FindGameObjectWithTag("GameTag");
             GameData GD = target.GetComponent<GameData>();
            GD.UpdateScore();
            GD.UpdateSpeed();
            GameObject myEplode = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(myEplode, explodeLifeTime);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.tag == "player")
        {
            Destroy(other.gameObject);
            print("You lose! :-(");
        }
    }
}
