using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class admob : MonoBehaviour {
    public static admob instance { set; get; }

    public string interstitialADID;
    InterstitialAd myinterstitilad;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        instance = this;
        myinterstitilad = new InterstitialAd(interstitialADID);
    }
    public void Loadinterstitialad()
    {
        AdRequest requeset = new AdRequest.Builder().Build();
        myinterstitilad.LoadAd(requeset);
    }

    public void showinterstitialad()
    {
        myinterstitilad.Show();
    }

}
