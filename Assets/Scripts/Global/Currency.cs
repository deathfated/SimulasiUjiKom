using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.MatchPicture.Global
{
    public class Currency : MonoBehaviour
    {
        public int Coin;
        private int _reward = 100;

        private void OnAddCoin()
        {
            Coin += _reward;
        }

        private void OnSpendCoin(int cost)
        {
            Coin -= cost;
        }
    }
}