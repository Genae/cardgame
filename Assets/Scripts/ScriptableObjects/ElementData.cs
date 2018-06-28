using System;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [Serializable, CreateAssetMenu]
    public class ElementData : ScriptableObject
    {
        public string Name;
        public Sprite Bubble;
    }
}
