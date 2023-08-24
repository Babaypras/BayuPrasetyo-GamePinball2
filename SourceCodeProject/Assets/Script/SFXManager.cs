using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public GameObject sfx;

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfx, spawnPosition, Quaternion.identity);
    }
}
