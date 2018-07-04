using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Manager{

    public static int player1Score = 0;
    public static int player2Score = 0;

    public static bool ai = false;
    public static bool twoBalls = false;
    private static float side = 0;

    public static void Score(string wall) {
        if (wall == "leftWall")
            player2Score++;
        else
            player1Score++;
    }

    public static void Reset() {
        player1Score = 0;
        player2Score = 0;
    }

    public static float getSide() {
        side = (side + 1) % 2;
        return side;
    }
}
