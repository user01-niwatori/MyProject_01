using Assets.Scripts.Common;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts.Manager
{
    /// <summary>
    /// 表示クラス
    /// </summary>
    public class DisplayManager : SingletonMonoBehaviour<DisplayManager>
    {
        /// <summary>
        /// 表示用テキスト
        /// </summary>
        [SerializeField, Header("DisplayLogText")]
        private GameObject m_displayLogText = null;

        [SerializeField, Header("LogContent")]
        private GameObject m_logContent = null;

        /// <summary>
        /// ログを表示する処理
        /// </summary>
        /// <param name="s"></param>
        public void Log(string s)
        {
            Debug.Log(s);
            var obj = Instantiate(m_displayLogText, transform.position, Quaternion.identity);
            obj.transform.SetParent(m_logContent.transform);
            obj.GetComponent<TextMeshProUGUI>().text = s;
        }
    }
}

