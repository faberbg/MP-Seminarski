using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter(){
        if(LapTimeManager.SecondCount<=9){
             SecondDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "0" + LapTimeManager.SecondCount + ".";
        }else{
            SecondDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapTimeManager.SecondCount + ".";
        }

        if(LapTimeManager.MinuteCount<=9){
             MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "0" + LapTimeManager.MinuteCount + ".";
        }else{
           MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MiliDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapTimeManager.MiliCount;
        LapTimeManager.MinuteCount=0;
        LapTimeManager.SecondCount=0;
        LapTimeManager.MiliCount=0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
