using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Deathfated.MatchPicture.Home
{
    public class HomeScene : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _themeButton;

        private void Start()
        {
            Button btn = _playButton.GetComponent<Button>();
            Button btn2 = _themeButton.GetComponent<Button>();
            btn.onClick.AddListener(OnClickPlay);
            btn2.onClick.AddListener(OnClickTheme);
        }

        void OnClickPlay()
        {
            SceneManager.LoadScene("GameplayScene");
        }

        void OnClickTheme()
        {
            SceneManager.LoadScene("ThemeScene");
        }
    }
}
