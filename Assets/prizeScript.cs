using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prizeScript : MonoBehaviour
{

    private int delay = 0;
    private bool okPickUp = true;

    private void Start()
    {
        this.GetComponent<ParticleSystem>().Stop();
    }

    private void Update()
    {
        delay++;
        if (delay == 15)
        {
            okPickUp = true;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (okPickUp)
        {
            okPickUp = false;
            delay = 0;

            //particle effect
            this.GetComponent<ParticleSystem>().Play();

            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
