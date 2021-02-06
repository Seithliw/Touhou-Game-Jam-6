using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Peg : MonoBehaviour
{
    public UnityEvent onHit;
    private bool lit;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (!lit) lit = true;
    }

}
