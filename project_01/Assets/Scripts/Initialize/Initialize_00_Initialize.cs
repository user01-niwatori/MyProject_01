using UnityEngine;
using Assets.Scripts.Manager;
using Assets.Scripts.Data;

namespace Assets.Scripts.Initialize
{

    /// <summary>
    /// 00_Initializeシーンの初期化クラス
    /// </summary>
    public class Initialize_00_Initialize : MonoBehaviour
    {
        [SerializeField, Header("ScriptableObjectのエクセルデータ")]
        private ExcelData m_excelData;

        void Start()
        {
            GameData.ExcelData = m_excelData;
            UnityAdsManager.Instance.Initialized();
            SaveDataManager.Instance.Initialized();
            //GameData.UserData.SetPlayerChara(GameData.UserData.SelectCharacterData.ID);
        }
    }
}
