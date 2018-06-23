using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public float score;
    public float speed;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void UpdateScore()
    {
        score = score + 1;
        print(score);
    }
    public void UpdateSpeed()
    {
        speed = (0.5f * score) + 2;
    }

}
