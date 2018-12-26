using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCook : MonoBehaviour
{

    public bool CreatingCookie = false;
    public static int CookieIncrease = 1;
    public int InternalIncrease ;
    public static int BakerAmount = 0;

    void Update()
    {
        InternalIncrease = CookieIncrease;
        if(CreatingCookie == false)
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }

    }

    IEnumerator CreateTheCookie ()
    {
        GlobalCookies.CookieCount += (InternalIncrease * BakerAmount);
        yield return new WaitForSeconds(2);
        CreatingCookie = false;
    }
}
