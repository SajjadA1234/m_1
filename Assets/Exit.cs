using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
  public void Exit_From_Program()  
    {  
        Application.Quit();  
        Debug.Log("Quit");
    }  
}
