using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperBounce : MonoBehaviour
{
    public Collider ball;
    public float powerBump;

    private Animator anim;
    public SFXManager audio;
    public VFXmanager vfx;

    public Scoring score;

    public float point;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == ball)
        {
            Rigidbody rigBall = ball.GetComponent<Rigidbody>();
            rigBall.velocity *= powerBump;

            score.AddScore(point);
            anim.SetTrigger("hit");

            audio.PlaySFX(collision.transform.position);

            vfx.PlayVFX(collision.transform.position);

            
        }
    }
}
