using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Manager{

    public static int player1Score = 0;
    public static int player2Score = 0;

    public static void Score(string wall) {
        if (wall == "leftWall")
            player2Score++;
        else
            player1Score++;
    }
}
