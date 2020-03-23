using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.Data;

/// <summary>
/// Awake前に00_Initializeを自動でロードするクラス
/// </summary>
public class AutoLoader
{
    // ゲーム開始時(シーン読み込み前)に実行される
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void LoadInitializeScene()
    {
        string managerSceneName = GameData.SCENE_INITIALIZE;

        // 00_Initializeが有効でない時(まだ読み込んでいない時)だけ追加ロードするように
        if (!SceneManager.GetSceneByName(managerSceneName).IsValid())
        {
            SceneManager.LoadScene(managerSceneName, LoadSceneMode.Additive);
        }
    }
}
