using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    void Update (){
        if(Input.GetButton("Menu")){
           SceneManager.LoadScene(2);
        }
    }
    
    
}
