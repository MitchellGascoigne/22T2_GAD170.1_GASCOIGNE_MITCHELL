using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class WeekTwoActivities : MonoBehaviour
    {
        // Information about my favourite game (name, hours played and cost)
        private string favouriteGame = "Witcher 3";
        private int hoursPlayed = 100;
        private float costOfGame = 80f;

        // Start is called before the first frame update
        void Start()
        {
            // / is divide
            float dollarsPerHour;
            dollarsPerHour = costOfGame / hoursPlayed;
            Debug.Log("My favourite game is " + favouriteGame + " I have played it for " + hoursPlayed + " hours, and it cost me $" + costOfGame + " Therefore, my value of dollars per hour is: " + dollarsPerHour);
        }

        // Update is called once per frame
        void Update()
        {
          

        }
    }
}