using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Obstacle
{
    /// <summary>
    /// 障害物クラス
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Obstacles : MonoBehaviour
    {

        /// <summary>
        /// 速度
        /// </summary>
        protected Vector2 m_velocity = Vector2.zero;

        /// <summary>
        /// RigidBody2D
        /// </summary>
        protected Rigidbody2D m_rigid2D = null;

        /// <summary>
        /// タイマー
        /// </summary>
        protected float m_timer = 0;

        /// <summary>
        /// Awake
        /// </summary>
        private void Awake()
        {
            m_rigid2D = GetComponent<Rigidbody2D>();
            m_rigid2D.gravityScale = 0.0f;
        }

        /// <summary>
        /// 移動処理
        /// </summary>
        protected virtual void Mover() { }

        /// <summary>
        /// ループ処理
        /// </summary>
        /// <returns></returns>
        private IEnumerator Loop()
        {
            while(true)
            {
                Mover();
                yield return null;
            }
        }

        /// <summary>
        /// ループ処理をスタートさせる処理
        /// </summary>
        public void StartLoop()
        {
            StartCoroutine(Loop());
        }
    }
}
