using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseSelect : MonoBehaviour
{           
    public void newG()    
     {        
      SceneManager.LoadScene("StorySplash");    
     }
    public void cont()    
     {        
      SceneManager.LoadScene("Continue");    
     }
    public void opt()    
     {        
      SceneManager.LoadScene("Options");    
     }
}
