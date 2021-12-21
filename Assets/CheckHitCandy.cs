using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHitCandy : MonoBehaviour
{
    public Rigidbody teapod;
    // Start is called before the first frame update
    void Start()
    {
        teapod.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.tag == "CandyHit")
    //     {
    //         CollectedListener.hitted = true;
    //         teapod.useGravity = true;
    //     }
    // }

    private void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "CandyHit")
        {
            CollectedListener.hitted = true;
            teapod.useGravity = true;
        }
    }
}
