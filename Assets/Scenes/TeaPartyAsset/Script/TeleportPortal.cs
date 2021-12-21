using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportPortal : MonoBehaviour
{
    public Transform player;
    public Transform portal;
    void Update() {
        float warp = Vector3.Distance(player.position, portal.position);
        if (warp < 2f) {
            SceneManager.LoadScene("CastleScene", LoadSceneMode.Single);
        }
    }
}
