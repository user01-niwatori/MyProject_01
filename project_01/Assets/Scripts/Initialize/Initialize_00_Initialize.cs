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
        void Start()
        {
            UnityAdsManager.Instance.Initialized();
            SaveDataManager.Instance.Initialized();

            string charaPrefabIDStr = "Prefabs/Characters/Character_" + string.Format("{0:00}", GameData.UserData.SelectCharacter.ID);

            GameData.UserData.PlayerObj = Instantiate((GameObject)Resources.Load(charaPrefabIDStr));
            Debug.Log(GameData.UserData.PlayerObj.name);
        }
    }
}
