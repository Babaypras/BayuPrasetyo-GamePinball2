using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public Collider ball;
    public GameObject gameOver;

    // Update is called once per frame
    void Start()
    {
        gameOver.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == ball)
        {
            Rigidbody rigBall = ball.GetComponent<Rigidbody>();
            gameOver.SetActive(true);
        }
        
    }
}
