using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int currentLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    private void Start()
    {
    // set our current level to one.
    int currentLevel = 1;

    // set our current XP to zero
    int currentXp = 0;
    // set our current XP Threshold to be our level multiplied by our 100.

    int currentXPThreshold = (currentLevel * 100);

    // Debug out our starting values of our level, xp and current xp threshold
    Debug.Log("Current Level =" + currentLevel);
    Debug.Log("Current xp =" + currentXp);
    Debug.Log("Current Xp Threshold =" + currentXPThreshold);
    // Increase the current XP by one hundred.
    int xpIncrease = (currentXp * 100);
    // Debug out our current XP.
    Debug.Log("Your xp increased by 100, you now have =" + xpIncrease);
        // check if our current XP is more than our threshold.
        if (xpIncrease > currentXp) ;
        {
            Debug.Log("You have gained Xp");
        }

        // if it is, then let's increase out level by one.
        if(currentXPThreshold > currentXp)
        { 
            currentLevel = (currentLevel + 1);
        }

        // let's also increase recalculate our current xp threshold as we've levelled up.
        currentXPThreshold = (currentLevel * 100);
        // Debug out our new level value, as well as our current XP and our next Threshold we need to hit.
        Debug.Log("Level is now:" + currentLevel);
        Debug.Log("Xp is now: " + currentXp * currentLevel);
        Debug.Log("Xp Threshold is now: " + currentXPThreshold);
    }
} 
