using System;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [Serializable, CreateAssetMenu]
    public class CardData : ScriptableObject
    {
        public string Name;
        public Sprite Artwork;
        public int Attack;
        public int Hitpoints;
        public int Defense;
        public int Piercing;
    }
}
