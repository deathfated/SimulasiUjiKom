using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.MatchPicture.Gameplay
{
    public class Tile : MonoBehaviour
    {
        SpriteRenderer spriteRenderer;
        public Sprite sprite;
        private bool IsSelected = false;

        private void Update()
        {
            if (Input.GetKeyDown("a"))
            {
                OnClicked();
            }
        }

        private void OnClicked()
        {
            if (IsSelected == false)
            {
                transform.GetChild(0).gameObject.SetActive(true);
                IsSelected = true;
                Debug.Log("clicky");
            }
            else
            {
                transform.GetChild(0).gameObject.SetActive(false);
                IsSelected = false;
            }
        }

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    
}