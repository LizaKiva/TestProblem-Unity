using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class CardSwitcher : MonoBehaviour
    {
        [SerializeField] private int value;
        [SerializeField] private PoolCard cards;
        [SerializeField] private Card card;

        private int card_index = 0;
        private int number_of_cards = 0;

        public void Start()
        {
            number_of_cards = cards.data.Count;

            if (number_of_cards > 0)
            {
                card.cardName.text = cards.data[card_index].cardName;
                card.cardNumber.text = card_index.ToString();
            }

            Solve();
        }

        public void SwitchCard()
        {
            if (number_of_cards > 0)
            {
                ++card_index;
                card_index %= number_of_cards;

                card.cardName.text = cards.data[card_index].cardName;
                card.cardNumber.text = card_index.ToString();
            }
        }

        int GetSecretValue()
        {
            int result = value;
            for (int i = 0; i < 49; ++i)
            {
                result *= value * value + i;
                result += 777;
                result %= number_of_cards + i;
            }
            return result % number_of_cards;
        }

        public void Solve()
        {
            // Здесь вам нужно написать фунцию из задания и вывести ее результат с помощью вывода, описанного ниже
            Debug.Log(GetSecretValue().ToString());
            Debug.Log("Ваш ответ");
        }
    }
}
