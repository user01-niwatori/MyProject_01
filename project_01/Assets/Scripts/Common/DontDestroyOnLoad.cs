using UnityEngine;

namespace Assets.Scripts.Common
{
    /// <summary>
    /// Objectを破棄せず保存するクラス
    /// </summary>
    public class DontDestroyOnLoad : MonoBehaviour
    {
        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}

