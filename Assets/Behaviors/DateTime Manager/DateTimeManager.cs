using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DateTimeManager : MonoBehaviour
{
    
    public TMP_Text milisecondsCounter;
    public TMP_Text formattedDateCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        milisecondsCounter.text = DateTime.Now.ToString("fffffff");
        formattedDateCounter.text = DateTime.Now.ToString("yyyy-MM-dd | hh:mm:ss");
    }
}
