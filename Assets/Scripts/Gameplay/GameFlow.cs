using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Deathfated.MatchPicture.Gameplay
{
    public class GameFlow : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverPanel;
        [SerializeField] private GameObject _winText;
        [SerializeField] private GameObject _loseText;

        GameObject tileGroup;

        private void Start()
        {
            _gameOverPanel.SetActive(false);
            _winText.SetActive(false);
            _loseText.SetActive(false);
        }

        private void Update()
        {
            
        }

        public void SetGameOverState()
        {
            _gameOverPanel.SetActive(true);
            if (tileGroup.GetComponent<TileGroup>()._isWin == true)
            {
                _winText.SetActive(true);
            }
            else
            {
                _loseText.SetActive(false);
            }
        }

        private void Awake()
        {
            tileGroup = GameObject.Find("TileGroup");
        }
    }
}