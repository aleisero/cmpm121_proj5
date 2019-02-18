using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prizeScript : MonoBehaviour
{

    private int delay = 0;
    private bool okPickUp = true;
    private GameObject UI;

    private void Start()
    {
        this.GetComponent<ParticleSystem>().Stop();

        UI = GameObject.FindWithTag("Title");
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

            Invoke("TurnOnUI", 3);
        }
    }

    private void TurnOnUI()
    {
        UI.SetActive(true);
    }
}
