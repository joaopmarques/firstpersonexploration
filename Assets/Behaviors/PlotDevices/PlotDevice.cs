using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotDevice : MonoBehaviour
{

  [TextArea(3, 10)]
  public string plotText = "You approached the floating blue cube. This message appeared. It has little significance.";

  GameObject narrativeManager;

  void Start()
  {
    narrativeManager = GameObject.Find("NarrativeManager");
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player")
    {
      narrativeManager.GetComponent<NarrativeController>().currentPlot = plotText;
    }
  }

  void OnTriggerExit(Collider other)
  {
    narrativeManager.GetComponent<NarrativeController>().currentPlot = "";
  }
}
