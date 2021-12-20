using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAndGate : MonoBehaviour
{
    public GameObject key;
    public GameObject gate_left;
    public GameObject gate_right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == gate_left.name || other.gameObject.name == gate_right.name) {
            key.SetActive(false);
            gate_left.SetActive(false);
            gate_right.SetActive(false);
        }
    }
}
