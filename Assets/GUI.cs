using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using ChartboostSDK;

public class GUI : MonoBehaviour {

	public Text textLog;
	public Text timeScale;
	int t = 0;

	void Start() {
		Chartboost.cacheRewardedVideo (CBLocation.Default);
	}

	public void DisplayAd() {
		string s = "";
		if (Chartboost.hasRewardedVideo (CBLocation.Default)) {
			s = "Available";
			Chartboost.showRewardedVideo(CBLocation.Default);
		}
		else
			s = "Not Available";

		t++;
		textLog.text = "Attemp #" + t + ": " + s;
	}

	void Update() {
		timeScale.text = "Time Scale: " + Time.timeScale;
	}

	void OnApplicationFocus(bool focus) {
		if (!focus)
			Chartboost.doUnityPause (false, false);
	}

}
