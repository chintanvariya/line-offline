using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupRewardVideo : MonoBehaviour
{
    public PopupHint popupHint;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdFullScreenContentFailed += OnRewardedAdFullScreenContentFailed;
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdFullScreenContentClosed += OnRewardedAdFullScreenContentClosedHandler;
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdNotReady += OnRewardedAdNotReady;
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdGranted += OnRewardedAdGranted;

    }
    private void OnDisable()
    {
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdFullScreenContentFailed -= OnRewardedAdFullScreenContentFailed;
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdFullScreenContentClosed -= OnRewardedAdFullScreenContentClosedHandler;
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdNotReady -= OnRewardedAdNotReady;
        GoogleMobileAds.Sample.RewardedAdController.OnRewardedAdGranted -= OnRewardedAdGranted;
    }

    public void Cancel()
    {
        gameObject.SetActive(false);
        GameManager.gameState = GameState.PLAYING;
    }

    public void GetMoreHints()
    {
        GameManager.gameState = GameState.PLAYING;
        GoogleMobileAds.Sample.RewardedAdController.ShowRewardedAd();
    }

    public void OnRewardedAdFullScreenContentFailed(AdError error)
    {

    }

    public void OnRewardedAdGranted()
    {
        GameDefine.hintCount = 10;
        popupHint.gameObject.SetActive(true);
        gameObject.SetActive(false); 
    }

    public void OnRewardedAdFullScreenContentClosedHandler()
    {

    }

    public void OnRewardedAdNotReady()
    {

    }
}
