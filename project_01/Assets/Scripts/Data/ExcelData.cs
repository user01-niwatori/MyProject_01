using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Data
{
    /// <summary>
    /// Excel�f�[�^�N���X
    /// </summary>
    [ExcelAsset]
    public class ExcelData : ScriptableObject
    {
        /// <summary>
        /// Excel����ǂݍ��ރL�����N�^�[�f�[�^
        /// </summary>
        public List<CharacterData> CharacterDatas;
    }
}
