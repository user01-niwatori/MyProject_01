using UnityEngine;
using Assets.Scripts.Data;
using Assets.Scripts.Manager;

namespace Assets.Scripts.Button
{
    /// <summary>
    /// レベルアップボタンクラス
    /// </summary>
    class LevelUpButton : MonoBehaviour
    {
        /// <summary>
        /// ステージレベルを上げる処理
        /// </summary>
        public void OnClick_DebugLevelUp()
        {

            GameData.UserData.AddLevel(1);
            DisplayManager.Instance.Log("レベルを上げました:" + GameData.UserData.StageLevel);
        }
    }
}