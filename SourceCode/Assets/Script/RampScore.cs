using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Collider ball;
    public Scoring score;
    
    public float point;

    private void OnTriggerEnter(Collider other)
    {
        if(other == ball)
        {
            score.AddScore(point);
        }
    }
}
