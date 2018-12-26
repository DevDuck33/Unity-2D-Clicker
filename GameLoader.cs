using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int SavedCookies;
    public int SavedCash;
    public int SavedBakers;
    public int SavedShops;
    public int SavedValue;

    public void Start()
    {
        if(MenuOptions.IsLoading == true)
        {
            SavedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = SavedCookies;

            SavedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = SavedCash;

            SavedBakers = PlayerPrefs.GetInt("SavedBakers");
            AutoCook.BakerAmount = SavedBakers;

            SavedShops = PlayerPrefs.GetInt("SavedShops");
            AutoSell.ShopAmount = SavedShops;

            SavedValue = PlayerPrefs.GetInt("SavedValue");
            SaveGame.SaveValue = SavedValue;
        }

    }
}
