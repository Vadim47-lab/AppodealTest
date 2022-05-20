using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class AdSettings : MonoBehaviour, IInterstitialAdListener, IRewardedVideoAdListener, IBannerAdListener, IMrecAdListener
{
    private const string AppKey = "5a8e1a61fe5fe20e03642f3a6a35eb78c32bd88dda5d8e19";

    private void Start()
    {
        int adTypes = Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO | Appodeal.BANNER_BOTTOM | Appodeal.MREC;
        Appodeal.initialize(AppKey, adTypes, true);

        Appodeal.setInterstitialCallbacks(this);
        Appodeal.setRewardedVideoCallbacks(this);
        Appodeal.setMrecCallbacks(this);
        Appodeal.setBannerCallbacks(this);
    }

    public void ShowInterstitial()
    {
        if (Appodeal.canShow(Appodeal.INTERSTITIAL) && !Appodeal.isPrecache(Appodeal.INTERSTITIAL))
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
        }
    }

    public void ShowRewardVideo()
    {
        if (Appodeal.canShow(Appodeal.REWARDED_VIDEO, "MyPlacement") && !Appodeal.isPrecache(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO, "MyPlacement");
        }
    }

    public void ShowMrecVideo()
    {
        int yAxis = Screen.currentResolution.height - Screen.currentResolution.height / 10;
        int xGravity = Appodeal.BANNER_HORIZONTAL_CENTER;

        if (Appodeal.canShow(Appodeal.MREC) && !Appodeal.isPrecache(Appodeal.MREC))
        {
            Appodeal.showMrecView(yAxis, xGravity, "default");
        }
    }

    public void HideMrec()
    {
        Appodeal.hideMrecView();
    }

    public void ShowBanner()
    {
        Appodeal.show(Appodeal.BANNER_BOTTOM);
    }

    public void HideBanner()
    {
        Appodeal.hide(Appodeal.BANNER_BOTTOM);
    }

    public void onInterstitialClicked()
    {
        Debug.Log("onInterstitialClicked");
    }

    public void onInterstitialClosed()
    {
        Debug.Log("onInterstitialClosed");
    }

    public void onInterstitialExpired()
    {
        Debug.Log("onInterstitialExpired");
    }

    public void onInterstitialFailedToLoad()
    {
        Debug.Log("onInterstitialFailedToLoad");
    }

    public void onInterstitialLoaded(bool isPrecache)
    {
        Debug.Log($"onInterstitialLoaded. isPrecache: {isPrecache}");
    }

    public void onInterstitialShowFailed()
    {
        Debug.Log("onInterstitialShowFailed");
    }

    public void onInterstitialShown()
    {
        Debug.Log("onInterstitialShown");
    }

    public void onRewardedVideoClicked()
    {
        Debug.Log("onRewardedVideoClicked");
    }

    public void onRewardedVideoClosed(bool finished)
    {
        Debug.Log($"onRewardedVideoClosed. finished: {finished}");
    }

    public void onRewardedVideoExpired()
    {
        Debug.Log("onRewardedVideoExpired");
    }

    public void onRewardedVideoFailedToLoad()
    {
        Debug.Log("onRewardedVideoFailedToLoad");
    }

    public void onRewardedVideoFinished(double amount, string name)
    {
        Debug.Log($"onRewardedVideoFinished. amount: {amount}, name: {name},");
    }

    public void onRewardedVideoLoaded(bool precache)
    {
        Debug.Log($"onRewardedVideoLoaded. precache: {precache}");
    }

    public void onRewardedVideoShowFailed()
    {
        Debug.Log("onRewardedVideoShowFailed");
    }

    public void onRewardedVideoShown()
    {
        Debug.Log("onRewardedVideoShown");
    }

    public void onBannerClicked()
    {
        Debug.Log("onBannerClicked");
    }

    public void onBannerExpired()
    {
        Debug.Log("onBannerExpired");
    }

    public void onBannerFailedToLoad()
    {
        Debug.Log("onBannerFailedToLoad");
    }

    public void onBannerLoaded(int height, bool isPrecache)
    {
        Debug.Log($"onBannerLoaded. height: {height}, isPrecache: {isPrecache},");
    }

    public void onBannerShown()
    {
        Debug.Log("onBannerShown");
    }

    public void onMrecClicked()
    {
        Debug.Log("onMrecClicked");
    }

    public void onMrecExpired()
    {
        Debug.Log("onMrecExpired");
    }

    public void onMrecFailedToLoad()
    {
        Debug.Log("onMrecFailedToLoad");
    }

    public void onMrecLoaded(bool isPrecache)
    {
        Debug.Log($"onMrecLoaded. isPrecache: {isPrecache}");
    }

    public void onMrecShown()
    {
        Debug.Log("onMrecShown");
    }
}