using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchesLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public GameObject AutoSells;
    public static float BakerCost;
    public static float ShopCost;

    public void StartAutoCookie()
    {
        AutoCook.BakerAmount += 1;
        AutoCookie.SetActive(true);
        GlobalCash.CashCount -= GlobalBaker.BakerValue;
        BakerCost = (float)GlobalBaker.BakerValue * 1.3f;
        GlobalBaker.BakerValue = (int)Mathf.Round(BakerCost);
        GlobalBaker.TurnOffButton = true;

    }

    public void StartAutoSell()
    {
        AutoSell.ShopAmount += 1;
        AutoSells.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.ShopValue;
        ShopCost = (float)GlobalShop.ShopValue * 1.3f;
        GlobalShop.ShopValue = (int)Mathf.Round(ShopCost);
        GlobalShop.TurnOffShopButton = true;

    }
}
