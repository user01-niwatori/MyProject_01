

namespace Assets.Scripts.Data
{
    /// <summary>
    /// キャラクターデータクラス
    /// クラスを丸ごと保存するために、データ変数はpublicにする。
    /// </summary>
    [System.Serializable]
    public class CharacterData
    {

        /// <summary>
        /// キャラの名前
        /// </summary>
        public string Name = "None";

        /// <summary>
        /// キャラのレアリティ
        /// </summary>
        public int Rarity = 0;

        /// <summary>
        /// キャラのライフ
        /// </summary>
        public float Life = 0;

        /// <summary>
        /// キャラの動くスピード
        /// </summary>
        public float MoveSpeed = 0;
    }
}
