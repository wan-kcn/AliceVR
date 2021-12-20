using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower : MonoBehaviour
{
    public GameObject XR_rig;
    private score score_script;
    // Start is called before the first frame update
    void Start()
    {
        score_script = XR_rig.GetComponent<score>();
    }

    // Update is called once per frame
    public void on_collect() {
        score_script.flowers += 1;
        this.gameObject.SetActive(false);
    }
}
