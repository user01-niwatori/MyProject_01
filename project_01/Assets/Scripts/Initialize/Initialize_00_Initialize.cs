using UnityEngine;
using Assets.Scripts.Manager;
using Assets.Scripts.Data;

namespace Assets.Scripts.Initialize
{
    /// <summary>
    /// 00_Initializeシーンの初期化クラス
    /// </summary>
    public class Initialize_00_Initialize : MonoBehaviour
    {
        void Start()
        {
            UnityAdsManager.Instance.Initialized();
            SaveDataManager.Instance.Initialized();

            Debug.Log("ログイン状態:" + GameData.UserData.IsLogin);
            Debug.Log("コインの数:" + GameData.UserData.Money);
            Debug.Log("ステージレベル:" + GameData.UserData.StageLevel);
        }
    }
}
