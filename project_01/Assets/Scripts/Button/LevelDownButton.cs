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
            if (GameData.UserData.StageLevel > 0)
            {
                GameData.UserData.StageLevel -= 1;
            }

            SaveDataManager.Instance.SaveUserData();
            DisplayManager.Instance.Log("レベルを下げました:" + GameData.UserData.StageLevel);
        }
    }
}