using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject FakeShopButton;
    public GameObject FakeShopText;
    public GameObject RealShopButton;
    public GameObject RealShopText;
    public static int ShopValue = 25;
    public static bool TurnOffShopButton = false;
    public GameObject ShopStats;
    public int CurrentCash;

    void Update()
    {
        CurrentCash = GlobalCash.CashCount;
        ShopStats.GetComponent<Text>().text = "Shops: " + AutoSell.ShopAmount;
        FakeShopText.GetComponent<Text>().text = "Buy Shop - " + ShopValue + "$";
        RealShopText.GetComponent<Text>().text = "Buy Shop - " + ShopValue + "$";
        if (CurrentCash >= ShopValue)
        {
            FakeShopButton.SetActive(false);
            RealShopButton.SetActive(true);
        }
        else
        {
            FakeShopButton.SetActive(true);
            RealShopButton.SetActive(false);
        }

        if (TurnOffShopButton == true)
        {
            FakeShopButton.SetActive(true);
            RealShopButton.SetActive(false);
            TurnOffShopButton = false;
        }
    }
}
