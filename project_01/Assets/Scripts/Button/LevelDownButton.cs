using UnityEngine;
using Assets.Scripts.Data;
using Assets.Scripts.Manager;

namespace Assets.Scripts.Button
{
    /// <summary>
    /// レベルダウンボタンクラス
    /// </summary>
    class LevelDownButton : MonoBehaviour
    {
        /// <summary>
        /// ステージレベルを下げる処理
        /// </summary>
        public void OnClick_DebugLevelDown()
        {
            GameData.UserData.AddLevel(-1);
            DisplayManager.Instance.Log("レベルを下げました:" + GameData.UserData.StageLevel);
        }
    }
}