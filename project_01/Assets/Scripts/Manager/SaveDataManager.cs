using UnityEngine;
using Assets.Scripts.Common;
using Assets.Scripts.Data;

namespace Assets.Scripts.Manager
{
    /// <summary>
    /// セーブデータ管理クラス
    /// </summary>
    public class SaveDataManager : SingletonMonoBehaviour<SaveDataManager>
    {
        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialized()
        {
            SetUserData();
        }

        /// <summary>
        /// ユーザデータをセーブする処理
        /// </summary>
        public void SaveUserData()
        {
            SaveData.SetClass<UserData>(GameData.SAVE_USERDATA, GameData.UserData);
            SaveData.Save();
        }

        /// <summary>
        /// 保存したユーザデータを現在のユーザーデータとして設定する
        /// </summary>
        public void SetUserData()
        {
            GameData.UserData = SaveData.GetClass<UserData>(GameData.SAVE_USERDATA, new UserData());
        }
    }
}
