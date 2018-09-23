using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMod : MonoBehaviour {

	void Start () {
        string appId = "ca-app-pub-6510313420673654~3050732925";
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        RequestBanner();
	}

    private void RequestBanner(){
        string adUnitId = "ca-app-pub-6510313420673654/2034940823";
        // Create a 320x50 banner at the top of the screen.
        BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
        // Create a 320x50 banner at the top of the screen.
        //bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
    }
}
