using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabitMovement : MonoBehaviour
{
    [SerializeField] private Transform parent;
    // [SerializeField] private Transform target1;
    // [SerializeField] private Transform target2;
    // [SerializeField] private Transform target3;
    // [SerializeField] private Transform target4;
    // [SerializeField] private Transform target5;
    // [SerializeField] private Transform target6;
    // [SerializeField] private Transform target7;
    // [SerializeField] private Transform target8;
    // [SerializeField] private Transform target9;
    [SerializeField] private float t;
    [SerializeField] private GameObject target;
    private int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("waypoint1");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = parent.position;
        Vector3 b = target.transform.position;
        parent.position = Vector3.MoveTowards(a, b, t);
        if(parent.position == target.transform.position){
            count = count + 1;
            target = GameObject.Find("waypoint"+count.ToString());
            if(count >= 10){
                this.gameObject.SetActive(false);
            }
        }
    }
}
