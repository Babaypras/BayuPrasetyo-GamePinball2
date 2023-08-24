using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider ball;
    public Material off;
    public Material on;

    public VFXmanager onVFX;
    public VFXmanager offVFX;

    public SFXManager onSFX;
    public SFXManager offSFX;

    public Scoring score;

    private SwitchState state;
    private Renderer renderer;

    public float point;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimer(5));
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            Toggle();
            
        }

        if (other == ball && state == SwitchState.On)
        {
            onVFX.PlayVFX(other.transform.position);
            onSFX.PlaySFX(other.transform.position);
        }
        if (other == ball && state == SwitchState.Off)
        {
            offVFX.PlayVFX(other.transform.position);
            offSFX.PlaySFX(other.transform.position);
        }
    }

    private void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = on;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = off;
            StartCoroutine(BlinkTimer(5));
        }
    }

    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);
            
        }
        else
        {
            Set(true);
        }

        score.AddScore(point);
    }
    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;
        for(int i = 0; i < times; i++)
        {
            renderer.material = on;
            yield return new WaitForSeconds(0.5f);
            renderer.material = off;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwitchState.Off;
    }

    private IEnumerator BlinkTimer(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
