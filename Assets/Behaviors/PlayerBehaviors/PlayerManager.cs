using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

  public int nextLevel = 1;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  // Reset the current level
  void ResetLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

  // Advance to the next level
  void LoadLevel(int levelIndex)
  {
    SceneManager.LoadScene(levelIndex);
  }

  void OnCollisionEnter(Collision collision)
  {
    // Reset the level when it collides with Kill-tagged GameObjects
    if (collision.gameObject.tag == "Kill")
    {
      ResetLevel();
    }

    if (collision.gameObject.tag == "NextLevel")
    {
      LoadLevel(nextLevel);
    }
  }
}
