using Assets.Scripts.Common;
using Assets.Scripts.Obstacle;
using UnityEngine;

namespace Assets.Scripts.Manager
{
    /// <summary>
    /// バトルを管理するクラス
    /// </summary>
    public class BattleManager : SingletonMonoBehaviour<BattleManager>
    {
        /// <summary>
        /// ゲーム上に配置されている障害物達
        /// </summary>
        private GameObject[] m_obstacle = null;

        /// <summary>
        /// 初期化
        /// </summary>
        private void Start()
        {
            m_obstacle = GameObject.FindGameObjectsWithTag("Obstacle");
        }

        /// <summary>
        /// バトルを始めた際に呼ばれる
        /// </summary>
        public void StartBattle()
        {
            //　障害物の更新処理実行
            foreach (var obs in m_obstacle)
            {
                obs.GetComponent<Obstacles>().StartLoop();
            }
        }
    }
}
