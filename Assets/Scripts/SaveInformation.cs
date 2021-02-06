using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {      
    }

    // Update is called once per frame
    void Update()
    {

    }       
    public void maiSelect()    
     {        
       PlayerPrefs.SetInt("charSelect",0); 
     }
    
    public void satSelect()    
     {        
       PlayerPrefs.SetInt("charSelect",1); 
     }
    
    public void levelOneStarted()    
     {        
       PlayerPrefs.SetInt("level",1); 
     }
    
    public void levelTwoStarted()    
     {        
       PlayerPrefs.SetInt("level",2); 
     }
    
    public void levelThreeStarted()    
     {        
       PlayerPrefs.SetInt("level",3); 
     }
    
    public void levelFourStarted()    
     {        
       PlayerPrefs.SetInt("level",4); 
     }
    
    public void levelFiveStarted()    
     {        
       PlayerPrefs.SetInt("level",5); 
     }
    
    public void gameCompleted()    
     {        
       PlayerPrefs.SetInt("level",6); 
     }
}
