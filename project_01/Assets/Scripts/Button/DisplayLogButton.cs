using UnityEngine;

namespace Assets.Scripts.Button
{ 

    /// <summary>
    /// ログ表示ボタンクラス
    /// </summary>
    public class DisplayLogButton : MonoBehaviour
    {
        [SerializeField, Header("ログリスト")]
        private GameObject m_logList = null;


        /// <summary>
        /// ログリストのOn/Off処理
        /// </summary>
        public void OnClick_DebugDisplayLog()
        {
            m_logList.SetActive(!m_logList.activeSelf);
        }
    }
}
