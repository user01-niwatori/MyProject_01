using UnityEngine;
using Assets.Scripts.Data;
using Assets.Scripts.Manager;

namespace Assets.Scripts.Button
{
    /// <summary>
    /// コインアップボタンクラス
    /// </summary>
    class CoinUpButton : MonoBehaviour
    {
        /// <summary>
        /// コインを増やす処理
        /// </summary>
        public void OnClick_DebugCoinUp()
        {
            GameData.UserData.AddMoney(1000);
            DisplayManager.Instance.Log("コインを増やしました:" + GameData.UserData.Money);
        }
    }
}