using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class RewardedAds : MonoBehaviour, IUnityAdsListener
{
    //DON'T FORGET TO TURN ON MONETIZATION IN UNITY!
    //Attach this script to your AdManager (just an empty object)
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize("id", true)    //Replace "id" with your own ID in Project Settings > Services > Ads. (example: "3762987" with "")
    }

    public void ShowAd(string p)
    {
        Advertisement.Show();
    }


    void IUnityAdsListener.OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(showResult == ShowResult.Finished)
        {
            //Reward
        }
        else if(showResult == ShowResult.Failed)
        {
            Debug.LogError("Ad not loaded. Check your connection!");
        }
    }

    void IUnityAdsListener.OnUnityAdsDidStart(string placementId)
    {

    }

    void IUnityAdsListener.OnUnityAdsReady(string placementId)
    {

    }

    void IUnityAdsListener.OnUnityAdsDidError(string message)
    {

    }
}
