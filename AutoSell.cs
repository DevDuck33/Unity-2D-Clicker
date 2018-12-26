using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{

    public bool SellingCookie = false;
    public static int ShopIncrease = 1;
    public int InternalIncrease;
    public static int ShopAmount = 0;

    void Update()
    {
        InternalIncrease = ShopIncrease;
        if (SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }

    }

    IEnumerator SellTheCookie()
    {
        if (GlobalCookies.CookieCount == 0)
        {
            SellingCookie = false;
        }
        else
        {
            GlobalCookies.CookieCount -= (InternalIncrease * ShopAmount);
            GlobalCash.CashCount += (InternalIncrease * ShopAmount);
            yield return new WaitForSeconds(2);
            SellingCookie = false;
        }
    }
}