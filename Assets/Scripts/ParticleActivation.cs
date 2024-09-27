using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivation : MonoBehaviour
{
    public GameObject particleSystem;
    private bool isOn = false;

    public void Activate()
    {
        if (isOn)
        {
            particleSystem.SetActive(false);
            isOn = false;
        }
        else
        {
            particleSystem.SetActive(true);
            isOn = true;
        }
    }
}
