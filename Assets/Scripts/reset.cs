using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class reset : MonoBehaviour
{
    public GameObject black_king;
    public GameObject black_knight;
    public GameObject black_queen;
    public GameObject white_bishop;
    public GameObject white_rook;
    public GameObject white_knight;
    public GameObject white_pawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void on_click() {
        black_king.SetActive(false);
        black_knight.SetActive(false);
        black_queen.SetActive(false);
        white_bishop.SetActive(false);
        white_knight.SetActive(false);
        white_pawn.SetActive(false);
        white_rook.SetActive(false);

        black_king.transform.SetPositionAndRotation(new Vector3(18.9780006f,3.07200003f,86.0790024f), new Quaternion(-0.707106829f,0,0,0.707106709f));
        black_knight.transform.SetPositionAndRotation(new Vector3(13.8000002f,3.07200003f,82.7180023f), new Quaternion(-0.707106829f,0,0,0.707106709f));
        black_queen.transform.SetPositionAndRotation(new Vector3(18.8409996f,2.9059999f,89.3970032f), new Quaternion(-0.707106829f,0,0,0.707106709f));
        white_bishop.transform.SetPositionAndRotation(new Vector3(15.46f,3.07200003f,79.3649979f), new Quaternion(-0.707106829f,0,0,0.707106709f));
        white_rook.transform.SetPositionAndRotation(new Vector3(23.8490009f,3.07200003f,79.3649979f), new Quaternion(-0.707106829f,0,0,0.707106709f));
        white_knight.transform.SetPositionAndRotation(new Vector3(24.0200005f,3.07200003f,81.1090012f), new Quaternion(0,0.70723021f,0.706983387f,0));
        white_pawn.transform.SetPositionAndRotation(new Vector3(24.0200005f,3.07200003f,84.3889999f), new Quaternion(-0.707106829f,0,0,0.707106709f));
        
        black_king.SetActive(true);
        black_knight.SetActive(true);
        black_queen.SetActive(true);
        white_bishop.SetActive(true);
        white_knight.SetActive(true);
        white_pawn.SetActive(true);
        white_rook.SetActive(true);
    }
}
