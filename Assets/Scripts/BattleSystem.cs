using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    public int style = 0;
    public int luck = 0;
    public int rhythm = 0;
    public int playerOnePowerLevel = 0;
    public int playerTwoPowerLevel = 0;
    public int playerOneChanceToWin = 0;
    public int playerTwoChanceToWin =0;

    private void Start()
    {

        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = style;
        style = Random.Range(1, 10);
        // luck should be random between 0-4
        int playerOneLuck = luck;
        luck = Random.Range(0, 4);
        // ryhtm should be random between 1-6
        int playerOneRhythm = rhythm;
        rhythm = Random.Range(1, 6);

        // style should be random between 1-10
        int playerTwoStyle = style;
        style = Random.Range(1, 10);
        // luck should be random between 0-4
        int playerTwoLuck = luck;
        luck = Random.Range(0, 4);
        // ryhtm should be random between 1-6
        int playerTwoRhythm = rhythm;
        rhythm = Random.Range(1, 6);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = (luck + style + rhythm);
        int playerTwoPowerLevel = (luck + style + rhythm);

        // Debug out the two players, power levels.
        Debug.Log (playerOnePowerLevel);
        Debug.Log (playerTwoPowerLevel);

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = playerOnePowerLevel + playerTwoPowerLevel;
        int playerOneChanceToWin = playerOnePowerLevel % totalPower * 100;
        int playerTwoChanceToWin = playerTwoPowerLevel % totalPower * 100;

        // Debug out the chance of each character to win.

        Debug.Log (playerOneChanceToWin);
        Debug.Log (playerTwoChanceToWin);

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  

        // Debug out which character has won, which has lost, or if it's a draw. 
        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.

        int playerOneXpWin = (int)((playerOneChanceToWin - playerTwoChanceToWin) / 5 + 5);
        int playerTwoXpWin = (int)((playerTwoChanceToWin - playerOneChanceToWin) / 5 + 5);
        int playerOneXpLoss = (int)(5 - (playerTwoChanceToWin - playerOneChanceToWin) / 5);
        int playerTwoXpLoss = (int)(5 -(playerOneChanceToWin - playerTwoChanceToWin) / 5);


        if (playerOneChanceToWin > playerTwoChanceToWin)
        {
            Debug.Log("Player one has gained: " + playerOneXpWin + "Xp. Player Two has gained: " + playerTwoXpLoss + "Xp.");
        }

        else
        {
            Debug.Log("Player Two has gained: " + playerTwoXpWin + "Xp. Player One has gained: " + playerOneXpLoss + "Xp.");
        }

    }
}
