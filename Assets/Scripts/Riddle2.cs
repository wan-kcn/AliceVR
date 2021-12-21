using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class Riddle2 : MonoBehaviour
{
    public GameObject checkbutton;
    public GameObject restartbutton;
    public GameObject flower;
    public TMP_Text correct;
    public TMP_Text incorrect;
    public XRSocketInteractor black_king_socket;
    public XRSocketInteractor black_knight_socket;
    public XRSocketInteractor black_queen_socket;
    public XRSocketInteractor white_bishop_socket;
    public XRSocketInteractor white_rook_socket;
    public XRSocketInteractor white_knight_socket;
    public XRSocketInteractor white_pawn_socket;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void on_click() {
        string black_king = "temp";
        string black_knight = "temp";
        string black_queen = "temp";
        string white_bishop = "temp";
        string white_rook = "temp";
        string white_knight = "temp";
        string white_pawn = "temp";

        if (black_king_socket.selectTarget != null) {
            black_king = black_king_socket.selectTarget.name;
        }

        if (black_queen_socket.selectTarget != null) {
            black_queen = black_queen_socket.selectTarget.name;
        }

        if (white_rook_socket.selectTarget != null) {
            white_rook = white_rook_socket.selectTarget.name;
        }

        if (white_bishop_socket.selectTarget != null) {
            white_bishop = white_bishop_socket.selectTarget.name;
        }

        if (black_knight_socket.selectTarget != null) {
            black_knight = black_knight_socket.selectTarget.name;
        }
        if (white_knight_socket.selectTarget != null) {
            white_knight = white_knight_socket.selectTarget.name;
        }
        if (white_pawn_socket.selectTarget != null) {
            white_pawn = white_pawn_socket.selectTarget.name;
        }
        

        if (black_king == "Chess King Black" && black_knight == "Chess Knight Black" && black_queen == "Chess Queen Black" 
        && white_bishop == "Chess Bishop White" && white_rook == "Chess Rook White" && white_knight == "Chess Knight White" && white_pawn == "Chess Pawn White") {
            Debug.Log(true);
            flower.SetActive(true);
            checkbutton.SetActive(false);
            restartbutton.SetActive(false);
            correct.text = "Correct!";
            correct.color = new Color(0f, 1.0f, 0f, 1.0f);
            correct.gameObject.SetActive(true);
        } else {
            incorrect.gameObject.SetActive(true);
            StartCoroutine(Countdown(2));
        }

    }
    IEnumerator Countdown(int seconds) {
        yield return new WaitForSeconds(seconds);
        incorrect.gameObject.SetActive(false);
        } 
}
