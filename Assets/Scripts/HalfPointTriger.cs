using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTriger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter(){
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}
