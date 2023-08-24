using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
    }

    public void AddScore(float added)
    {
        score += added;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
