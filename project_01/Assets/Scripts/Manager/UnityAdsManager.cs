using UnityEngine;
using Assets.Scripts.Common;
using UnityEngine.Advertisements;

namespace Assets.Scripts.Manager
{
    // 動画再生タイプ
    public enum AdType
    {
        CONTINUE,
    }

    /// <summary>
    /// UnityAds管理クラス
    /// </summary>
    public class UnityAdsManager : SingletonMonoBehaviour<UnityAdsManager>
    {
        /// <summary>
        /// 動画再生タイプ
        /// </summary>
        private AdType m_adType;

        /// <summary>
        /// 連続再生防止フラグ
        /// </summary>
        private bool m_showedFlg;

        /// <summary>
        /// AdsID
        /// </summary>
#if UNITY_IOS
        public const string ADS_IOS_ID = "3337771";
#elif UNITY_ANDROID
        public const string ADS_ANDROID_ID = "3337772";
#endif

        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialized()
        {
#if UNITY_IOS
        Advertisement.Initialize (ADS_IOS_ID);
#elif UNITY_ANDROID
        Advertisement.Initialize(ADS_ANDROID_ID);
#endif
        }

        /// <summary>
        /// 動画広告表示
        /// </summary>
        /// <param name="type"></param>
        public void ShowAd(AdType type)
        {
            // 広告を再生できるか調べる
            if (CanShowAd())
            {
                // 連続再生防止のためTrue
                m_showedFlg = true;
                m_adType = type;
                var options = new ShowOptions { resultCallback = HandleShowResult };
                switch (m_adType)
                {
                    case AdType.CONTINUE:
                        Advertisement.Show(options);
                        break;
                }
            }
        }

        /// <summary>
        /// 広告表示できるかどうか
        /// </summary>
        /// <returns></returns>
        public bool CanShowAd()
        {
            return Advertisement.IsReady() && m_showedFlg == false;
        }

        /// <summary>
        /// 動画広告結果
        /// </summary>
        /// <param name="result"></param>
        private void HandleShowResult(ShowResult result)
        {
            switch (result)
            {
                // 広告を最後まで見た
                case ShowResult.Finished:
                    switch (m_adType)
                    {
                        case AdType.CONTINUE:
                            break;
                    }
                    break;
                // 途広告を途中でスキップした
                case ShowResult.Skipped:
                    switch (m_adType)
                    {
                        case AdType.CONTINUE:
                            break;
                    }
                    break;
                // エラーが発生した
                case ShowResult.Failed:
                    break;
            }

            m_showedFlg = false;
        }
    }
}
