using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorMove : MonoBehaviour
{
    private Animator doorMover;
    

    void Start()
    {
        doorMover = this.GetComponent<Animator>();
    }
    
    public void Unlock()
    {
        doorMover.SetBool("keyGot", true);
    }
}
