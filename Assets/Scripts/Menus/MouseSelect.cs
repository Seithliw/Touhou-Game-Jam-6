using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseSelect : MonoBehaviour
{           
    public int currentLevel = 0;

    void Start()
    {      
     currentLevel = PlayerPrefs.GetInt("level");
    }
    public void newG()    
     {        
      SceneManager.LoadScene("StorySplash");    
     }
    public void cont()    
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
      SceneManager.LoadScene("Continue");    
     }
    public void opt()    
     {        
      SceneManager.LoadScene("Options");    
     }
    public void main()    
     {        
      SceneManager.LoadScene("MainMenu");    
     }
}
