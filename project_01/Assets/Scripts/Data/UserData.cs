using System.Collections.Generic;
using UnityEngine;

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
        /// プレイヤーオブジェクト
        /// </summary>
        public GameObject PlayerObj = null;

        /// <summary>
        /// 現在選択中のキャラクター
        /// </summary>
        public CharacterData SelectCharacter = null;

        /// <summary>
        /// 所持しているキャラクター達
        /// </summary>
        public List<CharacterData> MyCharacters = null;



        #endregion

    }
}
