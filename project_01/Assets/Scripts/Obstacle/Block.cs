using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Obstacle
{
    /// <summary>
    /// ブロック障害物クラス
    /// </summary>
    [RequireComponent(typeof(BoxCollider2D))]
    public class Block : Obstacles
    {
        /// <summary>
        /// MoveType
        /// </summary>
        enum MoveType
        {
            HORIZONTAL,
            VERTICAL,
        };

        /// <summary>
        /// 移動スピード
        /// </summary>
        [SerializeField, Header("移動にかかる時間")]
        protected int m_moveSpeedTime = 1;

        /// <summary>
        /// 現在の位置から移動する距離
        /// </summary>
        [SerializeField, Header("現在の位置から移動する距離")]
        private float m_moveDistance = 3.0f;

        /// <summary>
        /// 移動タイプ
        /// </summary>
        [SerializeField, Header("移動タイプ")]
        private MoveType m_moveType = MoveType.HORIZONTAL;

        /// <summary>
        /// 目標地点
        /// </summary>
        private Vector2 m_targetPoint = Vector2.zero;

        /// <summary>
        /// スタート地点
        /// </summary>
        private Vector2 m_defalutPos = Vector2.zero;

        /// <summary>
        /// ターン中か？
        /// </summary>
        private bool m_isTurn = false;

        /// <summary>
        /// Start
        /// </summary>
        private void Start()
        {
            m_defalutPos = transform.position;

            switch (m_moveType)
            {
                case MoveType.HORIZONTAL:
                    m_targetPoint = transform.position + new Vector3(m_moveDistance, 0.0f);
                    break;
                case MoveType.VERTICAL:
                    m_targetPoint = transform.position + new Vector3(0.0f, m_moveDistance);
                    break;
            }
        }

        /// <summary>
        /// 移動処理
        /// </summary>
        protected override void Mover()
        {
            // ターンフラグ切り替え可能なら、切り替える
            if (IsTurn()) { m_isTurn = !m_isTurn; }

            switch(m_moveType)
            {
                case MoveType.HORIZONTAL:
                    HorizontalMover();
                    break;
                case MoveType.VERTICAL:
                    VerticalMover();
                    break;
            }
        }

        /// <summary>
        /// 横移動
        /// </summary>
        private void HorizontalMover()
        {

            if (!m_isTurn)
            {
                m_velocity = Vector2.Lerp(m_defalutPos, m_targetPoint, m_timer);
            }
            else
            {
                m_velocity = Vector2.Lerp(m_targetPoint, m_defalutPos, m_timer);
            }

            transform.position = m_velocity;
        }

        /// <summary>
        /// 縦移動
        /// </summary>
        private void VerticalMover()
        {

            if (!m_isTurn)
            {
                m_velocity = Vector2.Lerp(m_defalutPos, m_targetPoint, m_timer);
            }
            else
            {
                m_velocity = Vector2.Lerp(m_targetPoint, m_defalutPos, m_timer);
            }

            transform.position = m_velocity;
        }

        /// <summary>
        /// ターンフラグ切り替え可能か？
        /// </summary>
        private bool IsTurn()
        {
            m_timer += Time.deltaTime / m_moveSpeedTime;

            if (m_timer >= 1.0f)
            {
                m_timer = 0;
                return true;
            }

            return false;
        }
    }
}
