using UnityEngine;
using System.Collections;
using Assets.Scripts.Data;
using Assets.Scripts.Manager;

/// <summary>
/// セーブデータを消去するボタンクラス
/// </summary>
public class SaveClearButton : MonoBehaviour
{
    /// <summary>
    /// セーブデータを消去する処理
    /// </summary>
    public void OnClick_DebugSaveClearButton()
    {
        SaveData.Clear();
        DisplayManager.Instance.Log("データを消去しました");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif   
    }
}
