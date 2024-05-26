using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class CardSwitcher : MonoBehaviour
    {
        [SerializeField] private PoolCard cards;
        [SerializeField] private Card currentCard;
        
        public void Start()
        {
            // Здесь вам нужно написать фунцию из задания и вывести ее результат с помощью вывода, описанного ниже
            Debug.Log("Ваш ответ");
        }

        public void SwitchCard()
        {
            int count = cards.cards.Count;
            for (int i = 0; i < count; ++i)
            {
                int currentNumber = Convert.ToInt32(currentCard.cardNumber);
                if (i == currentNumber)
                {
                    if (i == count - 1)
                    {
                        currentCard.cardNumber.text = Convert.ToString(0);
                        currentCard.cardName.text = Convert.ToString(cards.cards[0]);
                    }
                    else
                    {
                        currentCard.cardNumber.text = Convert.ToString(currentNumber + 1);
                        currentCard.cardName.text = Convert.ToString(cards.cards[i + 1]);
                    }

                }
            }
        }
    }
}