using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DateTimeManager : MonoBehaviour
{
  public TMP_Text milisecondsCounter;
  public TMP_Text formattedDateCounter;

  void Update()
  {
    milisecondsCounter.text = DateTime.Now.ToString("fffffff");
    formattedDateCounter.text = DateTime.Now.ToString("yyyy-MM-dd | hh:mm:ss");
  }
}
