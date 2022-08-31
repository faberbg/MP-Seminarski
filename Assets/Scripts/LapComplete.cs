using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;

    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;
    public GameObject RaceFinish;

    void Update(){
        if (LapsDone==3){
            RaceFinish.SetActive(true);
           // StartCoroutine(ToMenu());
        }
        
    }
   
   IEnumerator ToMenu(){
        
        yield return new WaitForSeconds(3);
        ButtonOption b = new ButtonOption();
        b.TrackSelect();
    }

   

    void OnTriggerEnter(){
        LapsDone +=1;
        RawTime=PlayerPrefs.GetFloat("RawTime");
        if(LapTimeManager.RawTime <= RawTime){

        
            if(LapTimeManager.SecondCount<=9){
             SecondDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "0" + LapTimeManager.SecondCount + ".";
            }else{
            SecondDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapTimeManager.SecondCount + ".";
            }

            if(LapTimeManager.MinuteCount<=9){
             MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "0" + LapTimeManager.MinuteCount + ":";
             }else{
           MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapTimeManager.MinuteCount + ":";
            }

             MiliDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapTimeManager.MiliCount;
        }
        

        PlayerPrefs.SetInt ("MinSave", LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt ("SecSave", LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MiliSave",LapTimeManager.MiliCount);
        PlayerPrefs.SetFloat("RawTime",LapTimeManager.RawTime);


        LapTimeManager.MinuteCount=0;
        LapTimeManager.SecondCount=0;
        LapTimeManager.MiliCount=0;
        LapTimeManager.RawTime=0;
        LapCounter.GetComponent<TMPro.TextMeshProUGUI>().text= "" + LapsDone;

       
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
        
    }
}
