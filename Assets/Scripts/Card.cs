using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    [Serializable]
    public class Card
    {
        [SerializeField]public Text cardNumber;
        [SerializeField]public Text cardName;
    }
}
