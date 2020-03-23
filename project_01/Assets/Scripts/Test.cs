using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Data;

public class Test : MonoBehaviour
{

    [System.Serializable]
    public class Player
    {
        [SerializeField]
        public int hp;
        public float atk;
        public string name;
        public List<string> items;
        public Player()
        {

            items = new List<string>();
            items.Add("ポーション");
            items.Add("エーテル");
            items.Add("エリクサー");
            hp = 10;
            atk = 100f;
            name = "クラウド";
        }

    }
    // Use this for initialization
    void Start()
    {
        //セーブデータの設定
        SaveData.SetClass<Player>("p1", new Player());
        SaveData.Save();

        Player getPlayer = SaveData.GetClass<Player>("p1", new Player());

        Debug.Log(getPlayer.name);
        Debug.Log(getPlayer.items.Count + "こアイテムを持ってます");
        Debug.Log(getPlayer.items[0] + getPlayer.items[1] + getPlayer.items[2]);


    }

    // Update is called once per frame
    void Update()
    {

    }
}