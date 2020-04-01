
namespace Assets.Scripts.Data
{
    /// <summary>
    /// ゲームデータクラス
    /// </summary>
    [System.Serializable]
    public class GameData
    {
        #region シーン名

        /// <summary>
        /// シーン名:00_Initializeシーン
        /// </summary>
        public const string SCENE_INITIALIZE = "00_Initialize";

        /// <summary>
        /// シーン名:02_Mainシーン
        /// </summary>
        public const string SCENE_MAIN = "02_Main";

        #endregion

        #region セーブデータキー

        /// <summary>
        /// UserDataのセーブキー
        /// </summary>
        public const string SAVE_USERDATA = "UserData";

        #endregion

        #region 一時保存クラス

        /// <summary>
        /// ユーザーデータクラス
        /// </summary>
        private static UserData m_userData;

        #endregion

        #region getter/setter

        /// <summary>
        /// ユーザーデータクラスのアクセッサ
        /// </summary>
        public static UserData UserData { get { return m_userData; } set { m_userData = value; } }

        #endregion
    }
}
