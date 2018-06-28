using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Cards
{
    [ExecuteInEditMode]
    public class Card : MonoBehaviour
    {
        public CardData CardData;

        //references
        public Text CardNameText;
        public Text CardAttackText;
        public Text CardPiercingText;
        public Text CardDefenseText;
        public Text CardHitpointsText;
        public Image CardArtwork;

        public Image CardPiercing;
        public Image CardDefense;

        void Start ()
        {
            InitCardFromData();
        }

        // Update is called once per frame
        void Update ()
        {
            if (runInEditMode)
            {
                InitCardFromData();
            }
        }

        private void InitCardFromData()
        {
            CardNameText.text = CardData.Name;
            CardArtwork.sprite = CardData.Artwork;
            CardAttackText.text = CardData.Attack + "";
            CardPiercingText.text = CardData.Piercing == 0 ? "" : CardData.Piercing + "";
            CardDefenseText.text = CardData.Defense == 0 ? "" : CardData.Defense + "";
            CardHitpointsText.text = CardData.Hitpoints + "";

            CardPiercing.enabled = CardData.Piercing > 0;
            CardDefense.enabled = CardData.Defense > 0;
        }
    }
}
