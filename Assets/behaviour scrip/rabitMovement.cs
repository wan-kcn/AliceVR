using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rabitMovement : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private Transform player;
    [SerializeField] private float t;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject grouper;
    public string rabbit_status = "init";
    public int count = 1;
    private float waitTime = 0f;
    public string wait_status = "false";
    [SerializeField] private Animator animator;
    [SerializeField] private Transform endPoint;
    void Start()
    {
        target = GameObject.Find("waypoint1");
    }

    void sync(){
        Vector3 targetDirection = new Vector3(0f, 0f, 0f) - new Vector3(transform.position.x, transform.position.y, transform.position.z);
        float singleStep = 10f * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        Debug.DrawRay(transform.position, newDirection, Color.red);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    void turnFace(){
        Vector3 targetDirection = player.position - parent.position;
        float singleStep = 3f * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(parent.forward, targetDirection, singleStep, 0.0f);
        Debug.DrawRay(parent.position, newDirection, Color.red);
        parent.rotation = Quaternion.LookRotation(newDirection);
    }

    void turnFace2(){
        Vector3 targetDirection = new Vector3(target.transform.position.x, parent.position.y, target.transform.position.z) - parent.position;
        float singleStep = 3f * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(parent.forward, targetDirection, singleStep, 0.0f);
        Debug.DrawRay(parent.position, newDirection, Color.red);
        parent.rotation = Quaternion.LookRotation(newDirection);
    }

    void wait () {
        Debug.Log("continue2");
        if(count < 10){
            count = count + 1;
            if(count <= 9){
                target = GameObject.Find("waypoint"+count.ToString());
            }
        }
        if(count == 10){
            grouper.gameObject.SetActive(false);
        }
        wait_status = "false";
    }

    IEnumerator Countdown (int seconds) {
        int counter = seconds;
        while (counter > 0) {
        yield return new WaitForSeconds (1);
            counter--;
        }
        wait ();
    }

    void Update()
    {
        Vector3 a = parent.position;
        Vector3 b = target.transform.position;

        if(rabbit_status == "moving"){
            turnFace2();
            animator.SetInteger("AnimIndex", 1);
            animator.SetTrigger("Next");
        }else{
            animator.SetInteger("AnimIndex", 0);
            animator.SetTrigger("Next");
        }

        float dist = Vector3.Distance(player.position, a);
        float warp = Vector3.Distance(player.position, endPoint.position);

        if(warp <= 2){
            SceneManager.LoadScene("CaveScene", LoadSceneMode.Single);
        }

        if(dist <= 20){
            rabbit_status = "moving";
            parent.position = Vector3.MoveTowards(a, (new Vector3(b.x, a.y, b.z)), t);
            if(parent.position.x == target.transform.position.x && parent.position.z == target.transform.position.z){
                if(wait_status == "false"){
                    StartCoroutine(Countdown(4));
                    wait_status = "true";
                }else{
                    turnFace();
                    rabbit_status = "stop";
                }
            }
        }else{
            rabbit_status = "stop";
        }
    }
}
