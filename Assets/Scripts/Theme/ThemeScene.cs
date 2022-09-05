using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Deathfated.MatchPicture.Theme
{
    public class ThemeScene : MonoBehaviour
    {
        [SerializeField] private Button _backButton;

        private void Start()
        {
            Button btn = _backButton.GetComponent<Button>();
            btn.onClick.AddListener(OnClickBack);

            static void OnClickBack()
            {
                SceneManager.LoadScene("HomeScene");
            }
        }
    }
}