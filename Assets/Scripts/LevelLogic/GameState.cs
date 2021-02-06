using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private Player playerType;
    private Cannon cannon;
    private bool specialReady;
    private int ballsRemaining = 10;
    private int ballsInPlay = 0;

    public void BallInPlay()
    {
        ballsInPlay++;
    }
    public void BallOutOfPlay()
    {
        ballsInPlay--;
    }
    public void FreeBall()
    {
        ballsRemaining++;
    }

    public void RefillBalls()
    {
        ballsRemaining = 10;
    }

}
