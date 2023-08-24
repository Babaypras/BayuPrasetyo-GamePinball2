using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXmanager : MonoBehaviour
{
    public GameObject vfx;
    // Start is called before the first frame update
    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfx, spawnPosition, Quaternion.identity);
    }
}
