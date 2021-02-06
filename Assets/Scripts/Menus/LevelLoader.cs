using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{         
    public int currentLevel;
    public bool levelBeaten;
    public string sceneName;

    void Start()
    {      
     Scene currentScene = SceneManager.GetActiveScene ();
     sceneName = currentScene.name;
     currentLevel = PlayerPrefs.GetInt("level");
    }

    void Update()
    {
      keyBoardLevel();
      levelBeaten = true;
    }  

    public void keyBoardLevel()    
     {        
      if (levelBeaten == true)
        { 
         switch (currentLevel)
          {
           case 1:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("level2");
             }
           break;
           case 2:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("level3");
             }
           break;
           case 3:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("level4");
             }
           break;
           case 4:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("level5");
             }
           break;
           case 5:
           if (Input.GetKeyDown(KeyCode.Return) )
             {
              SceneManager.LoadScene("Victory");
             }
           break;
          }
        } 
     }
 
    public void mouseLevel()    
     {                 
      if (sceneName == "StorySplash") 
         {
            SceneManager.LoadScene("level1");
         }

      if (levelBeaten == true)
        { 
         switch (currentLevel)
          {
           case 1:

            SceneManager.LoadScene("level2");

           break;
           case 2:
           
            SceneManager.LoadScene("level3");

           break;
           case 3:
           
            SceneManager.LoadScene("level4");

           break;
           case 4:

            SceneManager.LoadScene("level5");
             
           break;

           case 5:
            SceneManager.LoadScene("Victory");
           
           break;
          }
        } 
     }
}
