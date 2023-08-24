using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncerPower : MonoBehaviour
{
    public Collider ball;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    private bool isHold = false;

    // Update is called once per frame
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == ball)
        {
            ReadInput(ball);
        }
    }

    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timehold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timehold / maxTimeHold);

            yield return new WaitForEndOfFrame();
            timehold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}
