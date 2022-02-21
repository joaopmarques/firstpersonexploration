using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotDevice : MonoBehaviour
{

  public string narrativeText = "You approached the floating yellow cube. This message appeared.";

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      Debug.Log(narrativeText);
    }
  }
}
