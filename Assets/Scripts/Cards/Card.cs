using System.Linq;
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
        public Text NameText;
        public Text AttackText;
        public Text PiercingText;
        public Text DefenseText;
        public Text HitpointsText;
        public Text Cost1Text;
        public Text Cost2Text;
        public Text Cost3Text;
        public Text Cost4Text;

        public Image Artwork;

        public Image Piercing;
        public Image Defense;
        public Image Cost1;
        public Image Cost2;
        public Image Cost3;
        public Image Cost4;

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
            NameText.text = CardData.Name;
            Artwork.sprite = CardData.Artwork;
            AttackText.text = CardData.Attack + "";
            PiercingText.text = CardData.Piercing == 0 ? "" : CardData.Piercing + "";
            DefenseText.text = CardData.Defense == 0 ? "" : CardData.Defense + "";
            HitpointsText.text = CardData.Hitpoints + "";
            var cost = CardData.Cost.AsDictionary.OrderByDescending(kv => kv.Value).ToArray();
            Cost1Text.text = cost.Length >= 1 ? cost[0].Value + "" : "";
            Cost2Text.text = cost.Length >= 2 ? cost[1].Value + "" : "";
            Cost3Text.text = cost.Length >= 3 ? cost[2].Value + "" : "";
            Cost4Text.text = cost.Length >= 4 ? cost[3].Value + "" : "";

            Cost1.sprite = cost.Length >= 1 ? cost[0].Key.Bubble : Cost1.sprite;
            Cost2.sprite = cost.Length >= 2 ? cost[1].Key.Bubble : Cost2.sprite;
            Cost3.sprite = cost.Length >= 3 ? cost[2].Key.Bubble : Cost3.sprite;
            Cost4.sprite = cost.Length >= 4 ? cost[3].Key.Bubble : Cost4.sprite;

            Piercing.enabled = CardData.Piercing > 0;
            Defense.enabled = CardData.Defense > 0;

            Cost1.enabled = CardData.Cost.Count >= 1;
            Cost2.enabled = CardData.Cost.Count >= 2;
            Cost3.enabled = CardData.Cost.Count >= 3;
            Cost4.enabled = CardData.Cost.Count >= 4;
        }
    }
}
