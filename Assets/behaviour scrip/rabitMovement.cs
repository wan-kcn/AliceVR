using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabitMovement : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private Transform player;
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
    [SerializeField] private string rabbit_status;
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

        float dist = Vector3.Distance(player.position, a);

        if(dist <= 20){
            rabbit_status = "moving";
            parent.position = Vector3.MoveTowards(a, (new Vector3(b.x, a.y, b.z)), t);
            if(parent.position.x == target.transform.position.x && parent.position.z == target.transform.position.z){
                count = count + 1;
                target = GameObject.Find("waypoint"+count.ToString());
                if(count >= 10){
                    this.gameObject.SetActive(false);
                }
            }
        }else{
            rabbit_status = "stop";
        }
    }
}
