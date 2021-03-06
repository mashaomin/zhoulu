﻿using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class BAD : MonoBehaviour
{
#if UNITY_ANDROID
    string adUnitId = "ca-app-pub-4966484504552142/6991598235";
#elif UNITY_IPHONE
    string adUnitId = "ca-app-pub-4966484504552142/5362041542";
#else
    string adUnitId = "unexpected_platform";
#endif

    public GameObject BUI;
    private BannerView bannerView;

    // Use this for initialization
    void Start()
    {
        float num = (float)Screen.height / Screen.width;

        int num2 = PlayerPrefs.GetInt("AdmobInterstitial",0);

        if (num > 1.73f && num2 == 0)
        {
            UIChange();
            Showbanner();
        }
    }

    private void Showbanner()
    {
        //Debug.Log("showbanner");
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }

    private void UIChange()
    {
        //BUI.transform.position = new Vector3(0,28.6f,0);
        BUI.transform.Translate(new Vector3(0, 1.15f, 0));
    }
}