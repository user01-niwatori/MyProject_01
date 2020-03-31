using UnityEngine;
using Assets.Scripts.Obstacle;
using Assets.Scripts.Manager;

namespace Assets.Scripts.Button
{
    public class TapToStarButton : MonoBehaviour
    {
        [SerializeField, Header("Canvas_UI")]
        private GameObject m_Canvas_UI = null;

        /// <summary>
        /// TapToStartメッセージを押した際の処理
        /// </summary>
        public void OnClick_TapToStartButton()
        {
            // UIを非表示にする
            m_Canvas_UI.SetActive(false);
            // バトルを始める
            BattleManager.Instance.StartBattle();
        }
    }
}
