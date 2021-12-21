using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedListener : MonoBehaviour
{
    public GameObject[] UnCollectedObj;
//0: Rose, 1: teapod, 2:Duck

    public GameObject[] CollectedObj;

    private int numC = 0;
    static public bool hitted = false;

    public GameObject teapod;

    public GameObject Portal;

    public void Collected(int obj)
    {
        if(obj != 1)
        {
            CollectedObj[obj].SetActive(true);
            UnCollectedObj[obj].SetActive(false);
        } else if (obj == 2 && hitted)
        {
            CollectedObj[obj].SetActive(true);
            UnCollectedObj[obj].SetActive(false);
        }
        
    }

    private void Update()
    {
        if(numC >= 3)
        {
            Portal.SetActive(true);
        }
    }
}
