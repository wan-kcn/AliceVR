using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject item;
    public bool rotating = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotating) {
        item.transform.Rotate(new Vector3(0,1f,0));
        }
    }
    public void on_click() {
        rotating = false;
        Rigidbody rigid = item.GetComponent<Rigidbody>();
        rigid.useGravity = true;
    }
}
