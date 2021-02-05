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

    // Update is called once per frame
    void Update()
    {
      optionSpot();
      spotTracker();
      sceneSwap(); 
    }

    void optionSpot()
    {
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
              print("0");
              newGameSelect = true;
              continueSelect = false;
              optionSelect = false;
              break;
          case 1:
              print("1");
              newGameSelect = false;
              continueSelect = true;
              optionSelect = false;
              break;
          case 2:
              print("2");
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
           break;
          case 1:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("Continue");
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
