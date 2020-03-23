using System.Collections.Generic;

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
        /// ログイン状態か？
        /// </summary>
        public bool IsLogin = false;

        /// <summary>
        /// 所持しているコインの数
        /// </summary>
        public int Money = 100;

        /// <summary>
        /// 現在クリア済みのステージレベル
        /// </summary>
        public int StageLevel = 0;

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
