using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Riddle2 : MonoBehaviour
{
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
        string black_king = black_king_socket.selectTarget.name;
        string black_knight = black_knight_socket.selectTarget.name;
        string black_queen = black_queen_socket.selectTarget.name;
        string white_bishop = white_bishop_socket.selectTarget.name;
        string white_rook = white_rook_socket.selectTarget.name;
        string white_knight = white_knight_socket.selectTarget.name;
        string white_pawn = white_pawn_socket.selectTarget.name;
        
        if (black_king == "Chess King Black" && black_knight == "Chess Knight Black" && black_queen == "Chess Queen Black" 
        && white_bishop == "Chess Bishop White" && white_rook == "Chess Rook White" && white_knight == "Chess Knight White" && white_pawn == "Chess Pawn White") {
            Debug.Log(true);
        }
    }
}
