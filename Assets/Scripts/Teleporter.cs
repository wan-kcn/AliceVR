using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleporter : MonoBehaviour
{
    public Transform XR_rig;
    public Transform teleporter;
    public string scene; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    // Update is called once per frame
    void Update()
    {
        float warp = Vector3.Distance(XR_rig.position, teleporter.position);
        if (warp < 2f) {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }
}
