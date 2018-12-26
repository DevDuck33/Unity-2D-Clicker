using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCookie : MonoBehaviour
{

    public void ClickTheButton()
    {
        GlobalCookies.CookieCount += 1;
    }
}
