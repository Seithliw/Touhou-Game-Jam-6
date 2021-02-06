using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    public int menuSpot = 0;
    public bool newGameSelect = true;
    public bool continueSelect = false;
    public bool optionSelect = false;
    public int currentLevel = 0;

    void Start()
    {      
     currentLevel = PlayerPrefs.GetInt("level");
    }

    // Update is called once per frame
    void Update()
    {
      optionSpot();
      spotTracker();
      sceneSwap(); 
    }

    void optionSpot()
    {
      if (Input.GetKeyDown(KeyCode.Escape) )
        {
         SceneManager.LoadScene("MainMenu");
        }

      if(Input.GetKeyDown(KeyCode.DownArrow) )
        {
          if(menuSpot == 2) 
            {
              menuSpot = 0;
            }
          else 
            {
              menuSpot += 1;
            }
        }

      if(Input.GetKeyDown(KeyCode.UpArrow) )
        {
          if(menuSpot == 0) 
            {
              menuSpot = 2;
            }
          else 
            {
              menuSpot -= 1;
            }
        }
    }

    void spotTracker()
    {
      switch (menuSpot)
      {
          case 0:
              newGameSelect = true;
              continueSelect = false;
              optionSelect = false;
              break;
          case 1:
              newGameSelect = false;
              continueSelect = true;
              optionSelect = false;
              break;
          case 2:
              newGameSelect = false;
              continueSelect = false;
              optionSelect = true;
              break;
       }
     }

    void sceneSwap()
    {
      switch (menuSpot)
       {
          case 0:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("StorySplash");
             }
           if (Input.GetKeyDown(KeyCode.Escape) )
             {
              SceneManager.LoadScene("MainMenu");
             }
           break;
          case 1:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              if ( currentLevel == 0)
                {
                 SceneManager.LoadScene("Continue");
                }
              if ( currentLevel != 0)
                {
                 switch (currentLevel)
                  {
                   case 1:
                    SceneManager.LoadScene("level1");
                    break;
                   case 2:
                    SceneManager.LoadScene("level2");
                    break;
                   case 3:
                    SceneManager.LoadScene("level3");
                    break;
                   case 4:
                    SceneManager.LoadScene("level4");
                    break;
                   case 5:
                    SceneManager.LoadScene("level5");
                    break;
                  }
                }
              }
           break;
          case 2:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("Options");
             }
           break;
       }
    }

}
