using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    // Our variables used to determine the Multiplier Values.
    public float agilityMultiplier;
    public float intelligenceMultiplier;
    public float strengthMultiplier;

    void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = Random.Range(0,11);
        agility = Random.Range(0, 11);
        intelligence = Random.Range(0, 11);

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log("Strength =" + strength);
        Debug.Log("Agility =" + agility);
        Debug.Log("Intelligence =" + intelligence);

        // let's create some float temporary variables to hold our multiplier values.
        // create an agility multiplier should be set to 0.5
        // create a strength multiplier should be set to 1 
        // create an intelligence multiplier should be set to 2.

        agilityMultiplier = 0.5f;
        strengthMultiplier = 1f;
        intelligenceMultiplier = 2f;

        // Debug out our current multiplier values.
        Debug.Log("Agility Multiplier is " + agilityMultiplier);
        Debug.Log("Strength Multiplier is " + strengthMultiplier);
        Debug.Log("Intelligence Multiplier is " + intelligenceMultiplier);

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.

        style = (int)(strength * strengthMultiplier);
        float luckFloat  = intelligence * 1.5f;
        float rhythmFloat = agility * 0.5f;
       

        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log("Style = " + style);
        Debug.Log("Luck = " + luckFloat);
        Debug.Log("Rhythm = " + rhythmFloat);

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.

        int additionalPoints = 10 / 3;
        float upgradeStrength = (strength + additionalPoints);
        float upgradeAgility = (agility + additionalPoints);
        float upgradeIntelligence = (intelligence + additionalPoints);


        // Debug out our new physical stat values
        Debug.Log ("You have levelled up to strength: " + upgradeStrength);
        Debug.Log ("You have levelled up to agility: " + upgradeAgility);
        Debug.Log("You have levelled up to intelligence: " + upgradeIntelligence);

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.

        int newStyle = (int)(upgradeStrength * strengthMultiplier);
        int newRhythm = (int) (upgradeAgility * strengthMultiplier);
        int newLuck = (int) (upgradeIntelligence * strengthMultiplier);

        // Debug out our new dancing stat values

        Debug.Log("New stat value for style is: " + newStyle);
        Debug.Log("New stat value for Rhythm is: " + newRhythm);
        Debug.Log("New stat value for Luck is: " + newLuck);

    }
}
