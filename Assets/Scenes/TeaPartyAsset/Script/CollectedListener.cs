using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedListener : MonoBehaviour
{
    public GameObject[] UnCollectedObj;
    //0: Rose, 1: teapod, 2:Duck
    public GameObject[] CollectedObj;

    public GameObject[] DeleteObj;

    private int numC = 0;
    static public bool hitted = false;

    public GameObject teapod;

    public GameObject Portal;

    public bool[] checkCollected = {false, false, false};

    private void Start()
    {
        checkCollected[0] = false;
        checkCollected[1] = false;
        checkCollected[2] = false;
    }

    public void Collected(int obj)
    {
        if(obj != 1)
        {
            checkCollected[obj] = true;
            DeleteObj[obj].SetActive(false);
            CollectedObj[obj].SetActive(true);
            UnCollectedObj[obj].SetActive(false);
        } else if (obj == 1 && hitted)
        {
            checkCollected[obj] = true;
            DeleteObj[obj].SetActive(false);
            CollectedObj[obj].SetActive(true);
            UnCollectedObj[obj].SetActive(false);
        }
        
    }

    private void Update()
    {
        if(checkCollected[0] && checkCollected[1] && checkCollected[2])
        {
            Portal.SetActive(true);
        }
    }
}