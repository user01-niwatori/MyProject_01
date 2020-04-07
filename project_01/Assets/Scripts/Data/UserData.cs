using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Manager;

namespace Assets.Scripts.Data
{
    /// <summary>
    /// ユーザーデータクラス
    /// クラスを丸ごと保存するために、データ変数はpublicにする。
    /// </summary>
    [System.Serializable]
    public class UserData
    {
        #region データ変数

        /// <summary>
        /// 所持しているコインの数
        /// </summary>
        public int Money = 100;

        /// <summary>
        /// 現在クリア済みのステージレベル
        /// </summary>
        public int StageLevel = 0;

        /// <summary>
        /// プレイヤーキャラのオブジェクト
        /// </summary>
        public GameObject PlayerChara = null;

        /// <summary>
        /// 現在選択中のキャラクター
        /// </summary>
        public CharacterData SelectCharacterData = null;

        /// <summary>
        /// 所持しているキャラクター達
        /// </summary>
        public List<CharacterData> MyCharactersData = null;



        #endregion

        #region 関数

        /// <summary>
        /// プレイヤーキャラを設定する処理
        /// </summary>
        /// <param name="id">生成するキャラのID</param>
        public void SetPlayerChara(int id)
        {
            string charaPrefabIDStr = "Prefabs/Characters/Character_" + string.Format("{0:00}", id);
            GameData.UserData.PlayerChara = MonoBehaviour.Instantiate((GameObject)Resources.Load(charaPrefabIDStr));
            GameData.UserData.SelectCharacterData = GameData.ExcelData.CharacterDatas[id];
            SaveDataManager.Instance.SaveUserData();
        }

        /// <summary>
        /// ユーザーが所持するお金を追加する
        /// </summary>
        public void AddMoney(int value)
        {
            GameData.UserData.Money += value;
            SaveDataManager.Instance.SaveUserData();
        }

        /// <summary>
        /// レベルに値を追加する
        /// </summary>
        /// <param name="value"></param>
        public void AddLevel(int value)
        {
            int num = GameData.UserData.StageLevel + value;

            // 最大値を超えたら最大値を渡す
            num = System.Math.Min(num, GameData.MAX_STAGE_LEVEL);
            // 最小値を下回ったら最小値を渡す
            num = System.Math.Max(num, GameData.MIN_STAGE_LEVEL);

            GameData.UserData.StageLevel = num;
            SaveDataManager.Instance.SaveUserData();
        }

        #endregion
    }
}
