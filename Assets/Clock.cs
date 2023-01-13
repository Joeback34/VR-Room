using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour { 

    // Start is called before the first frame update
   
    

        public GameObject secondHand;
        public GameObject minuteHand;
        public GameObject hourHand;
        string oldSeconds;





    // Update is called once per frame
    void Update()
    {

        string seconds = System.DateTime.UtcNow.ToString("ss");
        print(seconds);
        
        if (seconds != oldSeconds)
        {
            UpdateTimer();
        }
        oldSeconds = oldSeconds;
    }

    void UpdateTimer()
    {
        int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int hourInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));

        print(hourInt + " : " + minutesInt + " : " + secondsInt);

        iTween.RotateTo(secondHand, iTween.Hash("z", secondsInt * 6 * -1, "time", 1, "easytype", "easeOutQuint"));
    }
    
        
    

}
