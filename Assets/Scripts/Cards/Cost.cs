using System;
using Assets.Scripts.ScriptableObjects;
using Assets.Scripts.Util;
using UnityEditor;

namespace Assets.Scripts.Cards
{
    [Serializable]
    public class Cost : SerializableDictionary<ElementData, int> { }

    [CustomPropertyDrawer(typeof(Cost))]
    public class CostDrawer : DictionaryDrawer<ElementData, int> { }
}
