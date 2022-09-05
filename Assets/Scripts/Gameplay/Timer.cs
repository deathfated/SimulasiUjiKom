using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Deathfated.MatchPicture.Gameplay
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private Text _textTimer;
        [SerializeField] private float _totalTime;
        private float _time;

        void Start()
        {
            _time = _totalTime;
        }

        void Update()
        {
            float _timeRounded = Mathf.RoundToInt(_time);
            _textTimer.text = $"{_timeRounded + "s"}";
            _time -= Time.deltaTime;

            if (_time <= 0)
            {
                //game over event
            }
        }
    }
}