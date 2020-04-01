using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Data
{
    /// <summary>
    /// Excelデータクラス
    /// </summary>
    [ExcelAsset]
    public class ExcelData : ScriptableObject
    {
        /// <summary>
        /// Excelから読み込むキャラクターデータ
        /// </summary>
        public List<CharacterData> CharacterDatas;
    }
}
