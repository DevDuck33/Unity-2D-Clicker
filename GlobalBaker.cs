using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject FakeButton;
    public GameObject FakeText;
    public GameObject RealButton;
    public GameObject RealText;
    public int CurrentCash;
    public static int BakerValue = 25;
    public static bool TurnOffButton = false;
    public GameObject BakerStats;

    void Update()
    {
        CurrentCash = GlobalCash.CashCount;
        BakerStats.GetComponent<Text>().text = "Bakers: " + AutoCook.BakerAmount;
        FakeText.GetComponent<Text>().text = "Buy Baker - " + BakerValue + "$";
        RealText.GetComponent<Text>().text = "Buy Baker - " + BakerValue + "$";
        if (CurrentCash >= BakerValue)
        {
            FakeButton.SetActive(false);
            RealButton.SetActive(true);
        }
        else
        {
            FakeButton.SetActive(true);
            RealButton.SetActive(false);
        }
        
        if(TurnOffButton == true)
        {
            FakeButton.SetActive(true);
            RealButton.SetActive(false);
            TurnOffButton = false;
        }
    }
}
