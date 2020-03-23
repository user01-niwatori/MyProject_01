﻿using UnityEngine;
using System;

namespace Assets.Scripts.Common
{
    /// <summary>
    /// シングルトン
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [DisallowMultipleComponent]
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        /// <summary>
        /// インスタンス
        /// </summary>
        private static T _instance;

        public static T Instance {
            get
            {
                if (_instance == null)
                {
                    Type t = typeof(T);

                    _instance = (T)FindObjectOfType(t);
                    if (_instance == null)
                    {
                        Debug.LogError(t + " をアタッチしているGameObjectはありません");
                    }
                }
                return _instance;
            }
        }

        virtual protected void Awake()
        {
            // 他のゲームオブジェクトにアタッチされているか調べる
            // アタッチされている場合は破棄する。
            CheckInstance();
        }

        /// <summary>
        /// インスタンスが生成されているか調べる
        /// </summary>
        protected bool CheckInstance()
        {
            // 生成されていなければインスタンス生成する
            if (_instance == null)
            {
                _instance = this as T;
                Debug.Log(_instance + "が生成されました。");
                return true;
            }
            else if (_instance == this)
            {
                return true;
            }

            // 生成されていたらインスタンス削除する
            Destroy(this.gameObject);
            return false;
        }
    }
}