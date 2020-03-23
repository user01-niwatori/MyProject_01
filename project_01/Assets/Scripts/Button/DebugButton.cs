using UnityEngine;
using Assets.Scripts.Data;

namespace Assets.Scripts.Button
{
    /// <summary>
    /// デバッグリスト表示ボタンクラス
    /// </summary>
    public class DebugButton : MonoBehaviour
    {
        [SerializeField, Header("デバッグリスト")]
        private GameObject m_debugList = null;

        /// <summary>
        /// デバッグリストのOn/Off処理
        /// </summary>
        public void OnClick_DebugButton()
        {
            m_debugList.SetActive(!m_debugList.activeSelf);

            // デバッグリスト表示中はゲーム時間を止める
            if(m_debugList.activeSelf)
            {
                Time.timeScale = 0.0f;
            }
            else
            {
                Time.timeScale = 1.0f;
            }
        }

    }
}
