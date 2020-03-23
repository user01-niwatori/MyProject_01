using UnityEngine;
using Assets.Scripts.Manager;

namespace Assets.Scripts.Button
{
    /// <summary>
    /// 広告表示ボタンクラス
    /// </summary>
    public class AdsButton : MonoBehaviour
    {
        // ボタンを押した際Unityの広告が流れる
        public void OnClickUnityAds()
        {
            UnityAdsManager.Instance.ShowAd(AdType.CONTINUE);
        }
    }
}
